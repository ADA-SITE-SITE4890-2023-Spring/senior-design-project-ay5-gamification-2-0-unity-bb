using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Linq;

public class Lectures : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Lecture Clicked");
        DownloadLecture();


    }

    public async void DownloadLecture()
    {
        foreach (Content lct in GameManager.Instance.lectures)
        {
            if (transform.parent.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text + lct.title == transform.GetComponentInChildren<TextMeshProUGUI>().text)
            {
                File lecture = await APIManager.Instance.GetContentAttachmentsAsync(PlayerController.Instance.currentRoom, lct.id, GameManager.Instance.authContext.access_token);
                APIManager.Instance.DownloadAttachmentAsync(PlayerController.Instance.currentRoom, lct.id, lecture.id, GameManager.Instance.authContext.access_token);
            }
        }
    }


}
