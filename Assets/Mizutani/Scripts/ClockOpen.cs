using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClockOpen : MonoBehaviour
{
    public GameObject ClockNazoPanel;
    public GameObject ClockOpenButton;

    public void OnClickClockOpenButton()
    {
        ClockNazoPanel.SetActive(true);
        ClockOpenButton.SetActive(false);
    }
}
