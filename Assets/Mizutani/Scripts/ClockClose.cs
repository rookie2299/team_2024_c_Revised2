using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockClose : MonoBehaviour
{
    public GameObject ClockNazoPanel;
    public GameObject ClockPanel;

    public void OnClickCloseButton()
    {
        ClockNazoPanel.SetActive(false);
        ClockPanel.SetActive(true);
    }
   
}
