using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class WeekDoors : MonoBehaviour, IPointerClickHandler
{
    private bool isOpen = false;
    private Transform doorParent;
    // Start is called before the first frame update
    void Start()
    {
        doorParent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        OpenDoor();
    }

    public void OpenDoor()
    {
        if (!isOpen && transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text != "")
        {
            doorParent.transform.DOLocalRotate(new Vector3(0, 100, 0), 0.5f);
            isOpen = true;
        }
        else
        {
            doorParent.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            isOpen = false;
        }
    }
}
