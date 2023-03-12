using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;
using System;
using UnityEngine.UI;
public class LoginManager : MonoBehaviour
{
    private const string CLIENT_ID = "fa5893df-6b24-49bd-aa0b-a37feabdeb0e";
    private const string CLIENT_SECRET = "eCMvFEVmJTjAXgIBev34DefBW5RY0a4";
    private const string REDIRECT_URI = "http://localhost:8000/callback";
    private const string AUTHORIZATION_ENDPOINT = "https://ada-staging.blackboard.com/learn/api/public/v1/oauth2/authorizationcode";
    private const string TOKEN_ENDPOINT = "https://ada-staging.blackboard.com/learn/api/public/v1/oauth2/token"; private string authorizationCode;
    private string accessToken;
    private string username;
    private string password; public InputField usernameField;
    public InputField passwordField; 
    
    public void Start()
    {
        username = "";
        password = "";

        GameObject loginButtonObj = GameObject.Find("LoginButton"); 
        Button loginButton = loginButtonObj.GetComponent<Button>(); 
        loginButton.onClick.AddListener(Login);
    }
    public void Login()
    {
        // Get the username and password from the input fields
        username = usernameField.text;
        password = passwordField.text;         // Redirect user to the authorization endpoint
        string authorizationUrl = AUTHORIZATION_ENDPOINT + "?redirect_uri=" + REDIRECT_URI + "&response_type=code&client_id=" + CLIENT_ID + "&scope=read";
        Application.OpenURL(authorizationUrl);
    }
    public void GetAccessToken(string code)
    {
        // Store the authorization code
        authorizationCode = code;         // Request access token from the token endpoint
        StartCoroutine(RequestAccessToken());
    }
    private IEnumerator RequestAccessToken()
    {
        // Prepare the request body
        string requestBody = "grant_type=password&username=" + username + "&password=" + password;
        byte[] bodyBytes = Encoding.UTF8.GetBytes(requestBody);         // Prepare the request headers
        string authorizationHeader = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(CLIENT_ID + ":" + CLIENT_SECRET));
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Content-Type", "application/x-www-form-urlencoded");
        headers.Add("Authorization", authorizationHeader);         // Send the request to the token endpoint
        UnityWebRequest request = new UnityWebRequest(TOKEN_ENDPOINT, "POST");
        request.uploadHandler = new UploadHandlerRaw(bodyBytes);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        request.SetRequestHeader("Authorization", authorizationHeader);
        yield return request.SendWebRequest(); if (request.result == UnityWebRequest.Result.Success)
        {
            // Parse the response JSON to extract the access token
            string responseJson = request.downloadHandler.text;
            AccessTokenResponse response = JsonUtility.FromJson<AccessTokenResponse>(responseJson);
            accessToken = response.access_token; Debug.Log("Access token: " + accessToken);
        }
        else
        {
            Debug.Log("Error requesting access token: " + request.error);
        }
    }

    [Serializable]
    private class AccessTokenResponse
    {
        public string access_token;
        public string token_type;
        public int expires_in;
        public string scope;
        public string user;
    }
}
