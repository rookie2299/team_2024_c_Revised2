using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClockCameraChange : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject ClockCamera;
    public GameObject ClockOpenButton;

    public void OnMouseDown()
    {
        
        ClockOpenButton.SetActive(true);
    }

    public void OnClickClockBackButton()
    {
        
        ClockOpenButton.SetActive(false);
    }
    
}
