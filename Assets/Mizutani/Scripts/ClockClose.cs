using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockClose : MonoBehaviour
{
    public GameObject ClockNazoPanel;
    public GameObject ClockOpenButton;

    public void OnClickCloseButton()
    {
        ClockNazoPanel.SetActive(false);
        ClockOpenButton.SetActive(true);
    }
   
}
