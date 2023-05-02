using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Linq;

public class Assignments : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Lecture Clicked");
        DownloadAssignment();
    }


    public async void DownloadAssignment()
    {
        for (int i = 0; i < GameManager.Instance.assignmentDictionary.Count; i++)
        {
            if (transform.GetComponent<TextMeshProUGUI>().text == GameManager.Instance.assignmentDictionary[i].Values.FirstOrDefault())
            {
                File assignment = await APIManager.Instance.GetContentAttachmentsAsync(PlayerController.Instance.currentRoom, GameManager.Instance.assignmentDictionary[i].Keys.FirstOrDefault(), GameManager.Instance.authContext.access_token);
                if (assignment != null)
                {
                    APIManager.Instance.DownloadAttachmentAsync(PlayerController.Instance.currentRoom, GameManager.Instance.assignmentDictionary[i].Keys.FirstOrDefault(), assignment.id, GameManager.Instance.authContext.access_token, "assignment" + assignment.id);
                }
                else
                {
                    GameManager.Instance.WriteToFile(GameManager.Instance.assignmentDictionary[i].Values.FirstOrDefault());
                }
            }
        }
    }
}
