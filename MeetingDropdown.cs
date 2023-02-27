using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MeetingDropdown : MonoBehaviour
{
    public string url = "https://ada-staging.blackboard.com";
    public string appKey = "fa5893df-6b24-49bd-aa0b-a37feabdeb0e";
    public string appSecret = "eCMvFEVmJTjAXgIBev34DefBW5RY0a4j";

    public Dropdown dropdown;

    void Start()
    {
        StartCoroutine(FetchMeetings());
    }

    IEnumerator FetchMeetings()
    {
        UnityWebRequest www = UnityWebRequest.Get($"{url}/learn/api/public/v1/courses/courseId:GAME20/meetings");
        www.SetRequestHeader("X-Blackboard-app-key", appKey);
        www.SetRequestHeader("X-Blackboard-app-secret", appSecret);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError(www.error);
        }
        else
        {
            MeetingList meetingList = JsonUtility.FromJson<MeetingList>(www.downloadHandler.text);

            // Now that you have the deserialized data, you can create a dropdown list
            // using the start times of the meetings
            CreateDropdownList(meetingList.results);
        }
    }


    void CreateDropdownList(List<Meeting> meetings)
    {
        dropdown.ClearOptions();

        List<string> options = new List<string>();
        foreach (Meeting meeting in meetings)
        {
            options.Add(meeting.start);
        }

        dropdown.AddOptions(options);
    }
}
