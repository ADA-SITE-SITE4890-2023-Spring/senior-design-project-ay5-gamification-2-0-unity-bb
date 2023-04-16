using UnityEngine;
using System.IO;
using System.Collections.Generic;
using TMPro;
using System;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get { return instance; } }
    private static GameManager instance;
    public string authorizationCode;
    public AuthContext authContext = new AuthContext();
    public float expireTime = 0;
    public bool refreshed = false;
    public List<Announcement> announcements = new List<Announcement>();
    public List<string> courseIds = new List<string>();
    public List<Course> courses = new List<Course>();
    public List<Dictionary<string, string>> assignmentDictionary = new List<Dictionary<string, string>>();
    public List<Content> lectures = new List<Content>();
    List<Content> assignments = new List<Content>();
    public TextMeshProUGUI txt;
    public TextMeshProUGUI txt1;
    private Vector3 startPos;


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

    private void Start()
    {
        expireTime = 0;
        refreshed = false;

        startPos = PlayerController.Instance.transform.position;
    }

    private void Update()
    {
        RefreshAuthContext();
    }

    public async void GetAuthContext(string authCode)
    {
        authContext = await APIManager.Instance.GetToken(authCode);
        expireTime = Time.time + authContext.expires_in;
        refreshed = true;
    }

    public async void RefreshAuthContext()
    {
        if ((Time.time >= expireTime) && refreshed)
        {
            refreshed = false;
            authContext = await APIManager.Instance.GetNewToken(authContext.refresh_token);
            expireTime = Time.time + authContext.expires_in;
            refreshed = true;
        }
    }

    public string ExtractText(string htmlInput)
    {
        string plainText = System.Net.WebUtility.HtmlDecode(htmlInput);
        plainText = System.Text.RegularExpressions.Regex.Replace(plainText, "<.*?>", "");

        // Replace escape characters with spaces and trim whitespace
        plainText = System.Text.RegularExpressions.Regex.Replace(plainText, @"[\r]+", " ");
        plainText = plainText.Trim();

        // Set the text output component
        return plainText;
    }

    public void WriteToFile(string str)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "myFile.txt");
        // Append the string to the file
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(str);
        }
    }

    public void ExitRoom()
    {
        lectures.Clear();
        assignmentDictionary.Clear();
        SoundManager.instance.Stop("Classroom");
        SoundManager.instance.Play("BG_Music");
        SoundManager.instance.Play("BG_Yard");
        PlayerController.Instance.transform.position = startPos;
    }
}