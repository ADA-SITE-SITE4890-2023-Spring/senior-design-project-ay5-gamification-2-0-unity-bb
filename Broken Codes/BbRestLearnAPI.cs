using System;
using System.Net;
using System.IO;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using TMPro;

using UnityEngine.UI;


public class BbRestLearnAPI : MonoBehaviour
{
    public string url = "https://ada-staging.blackboard.com";
    public string appKey = "fa5893df-6b24-49bd-aa0b-a37feabdeb0e";
    public string appSecret = "eCMvFEVmJTjAXgIBev34DefBW5RY0a4j";

    TokenManager tm;
    BbLearnDelegation bbld;
    AnnouncementList al;
    CourseContentList cl;
    //public TMP_Text courseNameText;
    //public TMP_Text availableText;
    public TMP_Text AnnName;
    public TMP_Text CourseContentName;
    //private string courseName;

    



    private void Awake()
    {
        Debug.Log("Getting Token Manager.....");
        tm = GetComponent<TokenManager>();
        bbld = GetComponent<BbLearnDelegation>();
        TestGetToken();
    }

    public async void TestGetToken()
    {
        Debug.Log("Testing call.....");
        var auth = System.Convert.ToBase64String(
            System.Text.Encoding.Default.GetBytes(
                $"{appKey}:{appSecret}"
            )
        );
        var basicAuth = $"Basic {auth}";
        WWWForm form = new WWWForm();
        form.AddField("grant_type", "client_credentials");
        Debug.Log($"{url}/learn/api/public/v1/oauth2/token");
        Debug.Log(basicAuth);
        using var www = UnityWebRequest.Post($"{url}/learn/api/public/v1/oauth2/token", form);
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
        Debug.Log(jsonResponse);
        BbAuthContext result = new BbAuthContext();
        try
        {
            result = JsonConvert.DeserializeObject<BbAuthContext>(jsonResponse);
            Debug.Log($"Success: {www.downloadHandler.text}");
        }
        catch (Exception ex)
        {
            Debug.Log($"{this} could not parse json {jsonResponse}. {ex.Message}");
        }

        //if (result.access_token != "")
        //{
        //    tm.setExpiresIn(result.expires_in);
        //}


        //TEST

        using var www2 = UnityWebRequest.Get($"{url}/learn/api/public/v1/courses/courseId:GAME20/announcements");
        www2.SetRequestHeader("Authorization", $"Bearer {result.access_token}");
        www2.SetRequestHeader("Content-Type", "application/json");

        operation = www2.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www2.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }
        jsonResponse = www2.downloadHandler.text;
        try
        {
            AnnouncementList a = JsonUtility.FromJson<AnnouncementList>(jsonResponse);
            Debug.Log($"Announcement title: {a.results[0].title}");

            string allTitles = "";
            foreach (Announcement announcement in a.results)
            {
                string announcementText = "<b>" + announcement.title + "</b>" + "\n" + announcement.body + "\n";
                allTitles += announcementText;
            }

            AnnName.text = allTitles;

            var contentItems = JsonConvert.DeserializeObject<BbContentItems>(jsonResponse);
            foreach (var item in contentItems.results)
            {
                bbld.CreateSpawn();
            }


        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }


        using var www3 = UnityWebRequest.Get($"{url}/learn/api/public/v1/courses/courseId:GAME20/contents/_202502_1/children");
        www3.SetRequestHeader("Authorization", $"Bearer {result.access_token}");
        www3.SetRequestHeader("Content-Type", "application/json");

        operation = www3.SendWebRequest();

        while (!operation.isDone)
        {
            await Task.Yield();
        }

        if (www3.result != UnityWebRequest.Result.Success)
        {
            Debug.Log($"Failed: {www.error}");
        }

        jsonResponse = www3.downloadHandler.text;
        try
        {
            CourseContentList c = JsonUtility.FromJson<CourseContentList>(jsonResponse);

            string allTitles1 = "";
            foreach (CourseContent coursecontents in c.results)
            {
                string courseText = "<b>" + coursecontents.title + "</b>" + "\n";
                allTitles1 += courseText;
            }

            CourseContentName.text = allTitles1;






            //CourseContentName.text = "";
            //foreach (CourseContent coursecontents in c.results)
            //{
            //    string courseText = $"<link={coursecontents.url}><b>{coursecontents.title}</b></link>\n";
            //    CourseContentName.text += courseText;
            //}

            //// Attach the CourseContentLink component to each link
            //foreach (TMP_LinkInfo linkInfo in CourseContentName.textInfo.linkInfo)
            //{
            //    GameObject linkGO = new GameObject("CourseContentLink");
            //    var link = linkGO.AddComponent<CourseContentLink>();
            //    link.SetLinkData(linkInfo.GetLinkID(), linkInfo.GetLinkText(), linkInfo.GetLinkID());
            //    linkGO.transform.SetParent(CourseContentName.transform, false);
            //    RectTransform rect = linkGO.GetComponent<RectTransform>();
            //    rect.anchoredPosition = linkInfo.GetLinkRect().position;
            //}

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

    }

}
