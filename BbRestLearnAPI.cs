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

// using BbLearnContext;
// App Key: b6e3a41f-b2f4-4735-9ba2-f9315dc76dcd
// Secret: We9c2aL4kstQnZO50Au0cF4zruPzXJFX
// Application ID: bc4bf3fe-e7f8-4541-b36b-abfcf1cdc98f

// App Key: 471af468-b2ed-4d92-ae3c-6259f8e7a01c
// Secret: S9d5H19BYUgPm6ddmM7PAW5yFMAF6EmE
// Application ID: 0fb259d8-8a7b-4943-a6d2-6910f4fcded2
// Basic YjZlM2E0MWYtYjJmNC00NzM1LTliYTItZjkzMTVkYzc2ZGNkOldlOWMyYUw0a3N0UW5aTzUwQXUwY0Y0enJ1UHpYSkZY

public class BbRestLearnAPI : MonoBehaviour {
    public string url = "https://ada-staging.blackboard.com";
    public string appKey = "fa5893df-6b24-49bd-aa0b-a37feabdeb0e";
    public string appSecret = "eCMvFEVmJTjAXgIBev34DefBW5RY0a4j";
    TokenManager tm;
    BbLearnDelegation bbld;
    [ContextMenu("Test Get Token")]

    private void Awake () {
        Debug.Log("Getting Token Manager.....");
        tm = GetComponent<TokenManager>();
        bbld = GetComponent<BbLearnDelegation>();
        TestGetToken();
    }

    public async void TestGetToken() {
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

        while (!operation.isDone) {
            await Task.Yield();
        }

        if (www.result != UnityWebRequest.Result.Success) {
            Debug.Log($"Failed: {www.error}");
        }

        var jsonResponse = www.downloadHandler.text;
        Debug.Log(jsonResponse);
        BbAuthContext result = new BbAuthContext();
        try {
            result = JsonConvert.DeserializeObject<BbAuthContext>(jsonResponse);
            Debug.Log($"Success: {www.downloadHandler.text}");
        } catch (Exception ex) {
            Debug.Log($"{this} could not parse json {jsonResponse}. {ex.Message}");
        }

        if (result.access_token != "") {
            tm.setExpiresIn(result.expires_in);
        }


        // TEST

        using var www2 = UnityWebRequest.Get($"{url}/learn/api/public/v1/courses/courseId:GAME20/announcements");
        www2.SetRequestHeader("Authorization", $"Bearer {result.access_token}");
        www2.SetRequestHeader("Content-Type", "application/json");

        operation = www2.SendWebRequest();

        while (!operation.isDone) {
            await Task.Yield();
        }

        if (www2.result != UnityWebRequest.Result.Success) {
            Debug.Log($"Failed: {www.error}");
        }
        jsonResponse = www2.downloadHandler.text;
        try {
            Debug.Log($"Success: {www2.downloadHandler.text}");

            var contentItems = JsonConvert.DeserializeObject<BbContentItems>(jsonResponse);
            foreach (var item in contentItems.results) {
                bbld.CreateSpawn();
            }


        } catch (Exception ex) {
            Debug.Log(ex.Message);
        }

        using var www3 = UnityWebRequest.Get($"{url}/learn/api/public/v1/courses/courseId:GAME20");
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
            Class1 cn = JsonUtility.FromJson<Class1>(jsonResponse);
            Debug.Log($"Course name: {cn.name}");
           
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
}
