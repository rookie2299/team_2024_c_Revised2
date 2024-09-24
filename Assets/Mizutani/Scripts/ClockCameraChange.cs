using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClockCameraChange : MonoBehaviour , IPointerClickHandler
{
    public GameObject MainCamera;
    public GameObject ClockCamera;
    public GameObject ClockPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        MainCamera.gameObject.SetActive(false);
        ClockCamera.gameObject.SetActive(true);
        ClockPanel.SetActive(true);
    }

    public void OnClickClockBackButton()
    {
        MainCamera.gameObject.SetActive(true);
        ClockCamera.gameObject.SetActive(false);
        ClockPanel.SetActive(false);
    }
    
}
