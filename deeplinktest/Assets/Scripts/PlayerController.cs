using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get { return instance; } }
    private static PlayerController instance;
    private Rigidbody rb;
    [SerializeField]
    private float movementSpeed;
    private float horizontal;
    private float vertical;
    private float currentVelocity;
    private float smoothTurnTime = 0.1f;
    private Vector3 direction;
    private Animator anim;
    private Transform cam;
    public string currentRoom;
    public TextMeshProUGUI announcementTitle;
    public TextMeshProUGUI announcementBody;
    public TextMeshProUGUI assignmentTitle;
    public TextMeshProUGUI assignmentBody;
    public int announcementNumber = 0;
    public int assignmentNumber = 0;
    public TextMeshProUGUI playerName;
    public GameObject nameCanvas;
    public bool isAuthorized = false;
    public bool portalsCreated = false;


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


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cam = Camera.main.transform;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {

        }
        PlayerMovement();
        nameCanvas.transform.LookAt(Camera.main.transform);
    }


    public void LogIn()
    {
        if (!isAuthorized && !portalsCreated)
        {
            APIManager.Instance.GetAuthorizationCode();
            isAuthorized = true; ;
        }
        else if (!portalsCreated && isAuthorized)
        {
            LoginCheck();
            portalsCreated = true;
        }
    }

    public async void LoginCheck()
    {
        string code = Application.absoluteURL.Substring(Application.absoluteURL.IndexOf("=") + 1);
        GameManager.Instance.authorizationCode = code;
        // GameManager.Instance.GetAuthContext(code);
        GameManager.Instance.authContext = await APIManager.Instance.GetToken(GameManager.Instance.authorizationCode);
        GameManager.Instance.expireTime = Time.time + GameManager.Instance.authContext.expires_in;
        GameManager.Instance.refreshed = true;
        GameManager.Instance.courseIds = await APIManager.Instance.GetCourseIdsAsync(GameManager.Instance.authContext.user_id, GameManager.Instance.authContext.access_token);
        for (int i = 0; i < GameManager.Instance.courseIds.Count; i++)
        {
            Course course = await APIManager.Instance.GetCourseAsync(GameManager.Instance.courseIds[i], GameManager.Instance.authContext.access_token);
            GameManager.Instance.courses.Add(course);
            Enviroment.Instance.portals[i].gameObject.SetActive(true);
            Enviroment.Instance.portals[i].GetComponentInChildren<TextMeshProUGUI>().text = GameManager.Instance.courses[i].name;
        }
        UserData userData = await APIManager.Instance.GetUserData(GameManager.Instance.authContext.user_id, GameManager.Instance.authContext.access_token);
        playerName.text = userData.userName;
    }



    private void PlayerMovement()
    {
        if (Enviroment.Instance.freeLookActive)
        {
            anim.SetFloat("Walk", direction.magnitude);
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            direction = new Vector3(horizontal, 0, vertical).normalized;
            if ((direction.magnitude > 0.01))
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref currentVelocity, smoothTurnTime);
                transform.rotation = Quaternion.Euler(0, angle, 0);
                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                rb.MovePosition(transform.position + (moveDir.normalized * movementSpeed * Time.fixedDeltaTime));
            }
        }

        if (Enviroment.Instance.freeLookActive == false)
        {
            anim.SetFloat("Walk", 0);
        }
    }

    private async void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Portal")
        {
            foreach (Course crs in GameManager.Instance.courses)
            {
                if (crs.name == other.transform.GetComponentInChildren<TextMeshProUGUI>().text)
                {
                    Content courseContent = new Content();
                    currentRoom = crs.courseId;
                    Content rootContent = await APIManager.Instance.GetRootContentAsync(currentRoom, GameManager.Instance.authContext.access_token);
                    if (rootContent != null)
                    {
                        List<Content> rootCourse = await APIManager.Instance.GetContentChildrenAsync(currentRoom, rootContent.id, GameManager.Instance.authContext.access_token);
                        foreach (Content content in rootCourse)
                        {
                            if (content.title == "Course Content")
                            {
                                courseContent = content;
                            }
                            else
                            {
                                courseContent = await APIManager.Instance.GetCourseContentAsync(currentRoom, GameManager.Instance.authContext.access_token);
                            }
                        }
                    }

                    List<Content> weeks = await APIManager.Instance.GetContentChildrenAsync(currentRoom, courseContent.id, GameManager.Instance.authContext.access_token);

                    for (int i = 0; i < weeks.Count; i++)
                    {
                        List<Content> getLecture = await APIManager.Instance.GetContentChildrenAsync(currentRoom, weeks[i].id, GameManager.Instance.authContext.access_token);
                        foreach (Content lecture in getLecture)
                        {
                            GameManager.Instance.lectures.Add(lecture);
                        }
                        Enviroment.Instance.weekShelves[i].GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text = weeks[i].title;
                        for (int j = 0; j < getLecture.Count; j++)
                        {
                            Enviroment.Instance.weekShelves[i].GetChild(j + 1).GetComponentInChildren<TextMeshProUGUI>().text = weeks[i].title + GameManager.Instance.lectures[j].title;
                        }
                    }
                }
            }

            Content assignment = await APIManager.Instance.GetAssignmentContentAsync(currentRoom, GameManager.Instance.authContext.access_token);
            List<Content> assignments = await APIManager.Instance.GetContentChildrenAsync(currentRoom, assignment.id, GameManager.Instance.authContext.access_token);
            foreach (Content assignmentContent in assignments)
            {
                Dictionary<string, string> newDict = new Dictionary<string, string>();
                var bodyText = GameManager.Instance.ExtractText(assignmentContent.body);
                newDict.Add(assignmentContent.id, bodyText);
                GameManager.Instance.assignmentDictionary.Add(newDict);
            }


            List<Group> groups = await APIManager.Instance.GetGroupsAsync(currentRoom, GameManager.Instance.authContext.access_token);
            if (groups.Count > 0)
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    Enviroment.Instance.groups[i].gameObject.SetActive(true);
                    Enviroment.Instance.groups[i].GetComponentInChildren<TextMeshProUGUI>().text = groups[i].name;
                }
            }

            GameManager.Instance.announcements = await APIManager.Instance.GetAnnouncementsAsync(currentRoom, GameManager.Instance.authContext.access_token);
            var gradeList = await APIManager.Instance.GetGradesAsync(currentRoom, GameManager.Instance.authContext.user_id, GameManager.Instance.authContext.access_token);
            for (int i = 0; i < gradeList.Count; i++)
            {
                Enviroment.Instance.grades[i].gameObject.SetActive(true);
                Enviroment.Instance.grades[i].GetChild(0).GetComponent<TextMeshProUGUI>().text = gradeList[i].displayGrade.title;
                Enviroment.Instance.grades[i].GetChild(1).GetComponent<TextMeshProUGUI>().text = gradeList[i].displayGrade.score.ToString() + "/" + gradeList[i].displayGrade.possible.ToString();
            }


            transform.position = new Vector3(13f, 0.32f, .5f);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            SoundManager.instance.Stop("BG_Music");
            SoundManager.instance.Stop("BG_Yard");
            SoundManager.instance.Play("Classroom");
            if (GameManager.Instance.announcements.Count > 0)
            {
                announcementTitle.text = GameManager.Instance.announcements[announcementNumber].title;
                announcementBody.text = GameManager.Instance.ExtractText(GameManager.Instance.announcements[announcementNumber].body);
            }
            if (GameManager.Instance.assignmentDictionary.Count > 0)
            {
                assignmentBody.text = GameManager.Instance.assignmentDictionary[0].Values.FirstOrDefault();
                assignmentTitle.text = "Assignment: " + (assignmentNumber + 1).ToString();
            }
        }
    }

    public void nextAnnouncement()
    {
        if (announcementNumber < GameManager.Instance.announcements.Count - 1)
        {
            announcementNumber++;
            announcementTitle.text = GameManager.Instance.announcements[announcementNumber].title;
            announcementBody.text = GameManager.Instance.ExtractText(GameManager.Instance.announcements[announcementNumber].body);
        }
        else if (announcementNumber == GameManager.Instance.announcements.Count - 1)
        {
            announcementNumber = 0;
            announcementTitle.text = GameManager.Instance.announcements[announcementNumber].title;
            announcementBody.text = GameManager.Instance.ExtractText(GameManager.Instance.announcements[announcementNumber].body);
        }
    }

    public void previousAnnouncement()
    {
        if (announcementNumber > 0)
        {
            announcementNumber--;
            announcementTitle.text = GameManager.Instance.announcements[announcementNumber].title;
            announcementBody.text = GameManager.Instance.ExtractText(GameManager.Instance.announcements[announcementNumber].body);
        }
        else if (announcementNumber == 0)
        {
            announcementNumber = GameManager.Instance.announcements.Count - 1;
            announcementTitle.text = GameManager.Instance.announcements[announcementNumber].title;
            announcementBody.text = GameManager.Instance.ExtractText(GameManager.Instance.announcements[announcementNumber].body);
        }
    }

    public void nextAssignment()
    {
        if (assignmentNumber < GameManager.Instance.assignmentDictionary.Count - 1)
        {
            assignmentNumber++;
            assignmentTitle.text = "Assignment: " + (assignmentNumber + 1).ToString();
            assignmentBody.text = assignmentBody.text = GameManager.Instance.assignmentDictionary[assignmentNumber].Values.FirstOrDefault();
        }
        else if (assignmentNumber == GameManager.Instance.assignmentDictionary.Count - 1)
        {
            assignmentNumber = 0;
            assignmentTitle.text = "Assignment: " + (assignmentNumber + 1).ToString();
            assignmentBody.text = assignmentBody.text = GameManager.Instance.assignmentDictionary[assignmentNumber].Values.FirstOrDefault();
        }
    }

    public void previousAssignment()
    {
        if (assignmentNumber > 0)
        {
            assignmentNumber--;
            assignmentTitle.text = "Assignment: " + (assignmentNumber + 1).ToString();
            assignmentBody.text = assignmentBody.text = GameManager.Instance.assignmentDictionary[assignmentNumber].Values.FirstOrDefault();
        }
        else if (assignmentNumber == 0)
        {
            assignmentNumber = GameManager.Instance.assignmentDictionary.Count - 1;
            assignmentTitle.text = "Assignment: " + (assignmentNumber + 1).ToString();
            assignmentBody.text = assignmentBody.text = GameManager.Instance.assignmentDictionary[assignmentNumber].Values.FirstOrDefault();
        }
    }

    public void PlayStep()
    {
        SoundManager.instance.Play("Step");
    }
}
