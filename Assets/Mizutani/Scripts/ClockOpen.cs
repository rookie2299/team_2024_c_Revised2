using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClockOpen : MonoBehaviour
{
    public GameObject ClockNazoPanel;
    public GameObject ClockPanel;

    public void OnClickClockOpenButton()
    {
        ClockNazoPanel.SetActive(true);
        ClockPanel.SetActive(false);
    }
}
