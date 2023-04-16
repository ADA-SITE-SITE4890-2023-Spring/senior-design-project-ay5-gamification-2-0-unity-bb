using UnityEngine;
using UnityEngine.Networking;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class APIManager : MonoBehaviour
{
    public static APIManager Instance { get { return instance; } }
    private static APIManager instance;

    private const string CLIENT_ID = "fa5893df-6b24-49bd-aa0b-a37feabdeb0e";
    private const string CLIENT_SECRET = "eCMvFEVmJTjAXgIBev34DefBW5RY0a4j";
    private const string REDIRECT_URI = "http://localhost:8080";
    //private const string AUTHORIZATION_ENDPOINT = "https://ada-staging.blackboard.com/learn/api/public/v1/oauth2/authorizationcode";
    private const string BASE_URL = "https://ada-staging.blackboard.com";

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Get authorization code
    public void GetAuthorizationCode()
    {
        // Redirect user to the authorization endpoint
        string authorizationUrl = BASE_URL + "/learn/api/public/v1/oauth2/authorizationcode?redirect_uri=" + REDIRECT_URI /*+ SceneManager.GetActiveScene()*/ + "&response_type=code&client_id=" + CLIENT_ID + "&scope=read";
        Application.OpenURL(authorizationUrl);
    }

    // Get token using authorization code
    public async Task<AuthContext> GetToken(string authCode)
    {
        AuthContext authContext = new AuthContext();
        var auth = System.Convert.ToBase64String(
            System.Text.Encoding.Default.GetBytes(
                $"{CLIENT_ID}:{CLIENT_SECRET}"
            )
        );
        var basicAuth = $"Basic {auth}";
        WWWForm form = new WWWForm();
        form.AddField("grant_type", "authorization_code");
        form.AddField("code", authCode);
        form.AddField("redirect_uri", REDIRECT_URI);
        using var www = UnityWebRequest.Post(BASE_URL + "/learn/api/public/v1/oauth2/token", form);
        www.SetRequestHeader("Authorization", basicAuth);
        www.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }
        var jsonResponse = www.downloadHandler.text;
        try
        {
            authContext = JsonConvert.DeserializeObject<AuthContext>(jsonResponse);
        }
        catch (Exception ex)
        {
            Debug.Log($"{this} could not parse json {jsonResponse}. {ex.Message}");
        }
        return authContext;
    }

    // Get new token using refresh token
    public async Task<AuthContext> GetNewToken(string refreshToken)
    {
        AuthContext authContext = new AuthContext();
        var auth = System.Convert.ToBase64String(
            System.Text.Encoding.Default.GetBytes(
                $"{CLIENT_ID}:{CLIENT_SECRET}"
            )
        );
        var basicAuth = $"Basic {auth}";
        WWWForm form = new WWWForm();
        form.AddField("grant_type", "refresh_token");
        form.AddField("refresh_token", refreshToken);
        form.AddField("redirect_uri", REDIRECT_URI);
        using var www = UnityWebRequest.Post(BASE_URL + "/learn/api/public/v1/oauth2/token", form);
        www.SetRequestHeader("Authorization", basicAuth);
        www.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }
        var jsonResponse = www.downloadHandler.text;
        try
        {
            authContext = JsonConvert.DeserializeObject<AuthContext>(jsonResponse);
        }
        catch (Exception ex)
        {
            Debug.Log($"{this} could not parse json {jsonResponse}. {ex.Message}");
        }
        return authContext;
    }

    // Get registered course ids : API - course memberships
    public async Task<List<string>> GetCourseIdsAsync(string user_uuid, string access_token)
    {
        List<string> courseIds = new List<string>();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/users/uuid:" + user_uuid + "/courses/");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;

        try
        {
            MyCourses myCourses = JsonConvert.DeserializeObject<MyCourses>(jsonResponse);

            foreach (Course course in myCourses.results)
            {
                courseIds.Add(course.courseId);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return courseIds;
    }

    // Get course by primary course id : API - courses
    public async Task<Course> GetCourseAsync(string primary_id, string access_token)
    {
        Course course = new Course();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v3/courses/" + primary_id);
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;

        try
        {
            course = JsonUtility.FromJson<Course>(jsonResponse);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return course;
    }

    // Get courseContent by courseId : API - content
    public async Task<Content> GetCourseContentAsync(string courseId, string access_token)
    {
        Content courseContent = new Content();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/contents");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        Debug.Log(jsonResponse);
        try
        {
            Contents contents = JsonConvert.DeserializeObject<Contents>(jsonResponse);
            foreach (Content content in contents.results)
            {
                if (content.title == "Course Content")
                {
                    courseContent = content;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return courseContent;
    }

    // Get content's children contents by courseId and contentId : API - content
    public async Task<List<Content>> GetContentChildrenAsync(string courseId, string contentId, string access_token)
    {
        List<Content> contentChildren = new List<Content>();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/contents/" + contentId + "/children");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        Debug.Log(jsonResponse);
        try
        {
            Contents contents = JsonConvert.DeserializeObject<Contents>(jsonResponse);
            foreach (Content content in contents.results)
            {
                contentChildren.Add(content);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return contentChildren;
    }

    // Get content's attachments by courseId and contentId : API - content file attachments
    public async Task<File> GetContentAttachmentsAsync(string courseId, string contentId, string access_token)
    {
        File lecture = new File();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/contents/" + contentId + "/attachments");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }
        var jsonResponse = www.downloadHandler.text;
        try
        {
            Files files = JsonConvert.DeserializeObject<Files>(jsonResponse);
            foreach (File file in files.results)
            {
                lecture = file;
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return lecture;
    }

    // Download attachment : API - content file attachments
    public async void DownloadAttachmentAsync(string courseId, string contentId, string attachmentId, string access_token)
    {
        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/contents/" + contentId + "/attachments/" + attachmentId + "/download");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        byte[] pdfBytes = www.downloadHandler.data;
        string filePath = "Assets/Resources/myFile.pdf";

        try
        {
            System.IO.File.WriteAllBytes(filePath, pdfBytes);
            Debug.Log($"File saved to {filePath}");
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    // Get course's groups : API - groups
    public async Task<List<Group>> GetGroupsAsync(string courseId, string access_token)
    {
        List<Group> groups = new List<Group>();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v2/courses/courseId:" + courseId + "/groups");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;

        try
        {
            GroupList groupList = JsonUtility.FromJson<GroupList>(jsonResponse);
            foreach (Group group in groupList.results)
            {
                groups.Add(group);
            }

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return groups;
    }

    // Get grade column : API - course grades
    public async Task<string> GetGradeForColumnAsync(string courseId, string columnId, string userId, string access_token)
    {
        Column column = new Column();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v2/courses/courseId:" + courseId + "/gradebook/columns/" + columnId);
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;

        try
        {
            column = JsonConvert.DeserializeObject<Column>(jsonResponse);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return column.name;
    }

    // Get grades for given user : API - course grades
    public async Task<List<Grade>> GetGradesAsync(string courseId, string userId, string access_token)
    {
        List<Grade> gradeList = new List<Grade>();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v2/courses/courseId:" + courseId + "/gradebook/users/uuid:" + userId);
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }
        var jsonResponse = www.downloadHandler.text;
        try
        {
            Grades grades = JsonUtility.FromJson<Grades>(jsonResponse);
            foreach (Grade grade in grades.results)
            {
                gradeList.Add(grade);
            }
            foreach (Grade grade in gradeList)
            {
                grade.displayGrade.title = await GetGradeForColumnAsync(courseId, grade.columnId, userId, access_token);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return gradeList;
    }

    // Get announcements : API - announcements
    public async Task<List<Announcement>> GetAnnouncementsAsync(string courseId, string access_token)
    {
        List<Announcement> announcements = new List<Announcement>();
        using var www2 = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/announcements");
        www2.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www2.SetRequestHeader("Content-Type", "application/json");

        var operation = www2.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }
        if (www2.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www2.error}");
        }

        var jsonResponse = www2.downloadHandler.text;

        try
        {
            AnnouncementList a = JsonUtility.FromJson<AnnouncementList>(jsonResponse);
            foreach (Announcement announcement in a.results)
            {
                announcements.Add(announcement);
            }

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
        return announcements;
    }

    //Get course's assignments : API - assignments
    public async Task<Content> GetAssignmentContentAsync(string courseId, string access_token)
    {
        Content assignmentContent = new Content();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/contents");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        try
        {
            Contents contents = JsonConvert.DeserializeObject<Contents>(jsonResponse);
            foreach (Content content in contents.results)
            {
                if (content.title == "Assignments")
                {
                    assignmentContent = content;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return assignmentContent;
    }

    // Get course's tests : API - tests
    public async Task<List<Content>> GetTestContentAsync(string courseId, string access_token)
    {
        Content test = new Content();
        List<Content> tests = new List<Content>();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/contents");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;

        try
        {
            Contents contents = JsonConvert.DeserializeObject<Contents>(jsonResponse);
            foreach (Content content in contents.results)
            {
                if (content.title == "Tests")
                {
                    test = content;
                }
            }
            var testId = test.id;
            tests = await GetContentChildrenAsync(courseId, test.id, access_token);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
        return tests;
    }

    public async void GetQuizAsync(string courseId, string assessmentId, string access_token)
    {
        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/assessments/" + assessmentId + "/questions");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        Debug.Log(jsonResponse);
        try
        {

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    public async void GetQuizQuestionAsync(string courseId, string assessmentId, string questionId, string access_token)
    {
        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/assessments/" + assessmentId + "/questions/" + questionId);
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        Debug.Log(jsonResponse);
        try
        {

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }


    public async Task<List<Content>> GetContentChildrenTestAsync(string courseId, string contentId, string access_token)
    {
        List<Content> contentChildren = new List<Content>();

        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/courses/courseId:" + courseId + "/contents/" + contentId);
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");

        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        try
        {
            Contents contents = JsonConvert.DeserializeObject<Contents>(jsonResponse);
            foreach (Content content in contents.results)
            {
                contentChildren.Add(content);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

        return contentChildren;
    }

    public async Task<UserData> GetUserData(string user_uuid, string access_token)
    {
        UserData userData = new UserData();
        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/users/uuid:" + user_uuid);
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        Debug.Log(jsonResponse);
        try
        {
            userData = JsonConvert.DeserializeObject<UserData>(jsonResponse);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
        return userData;
    }


    public async Task<string> GetUserAvatar(string user_uuid, string access_token)
    {
        using var www = UnityWebRequest.Get($"{BASE_URL}/learn/api/public/v1/users/uuid:" + user_uuid + "/avatar");
        www.SetRequestHeader("Authorization", $"Bearer {access_token}");
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        Debug.Log(jsonResponse);
        try
        {

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
        return jsonResponse;
    }

}
