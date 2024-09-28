using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockClear : MonoBehaviour
{

    public GameObject ClockClearPanel1;
    public GameObject ClockClearPanel2;
    public GameObject ClockClearPanel3;
    public GameObject ClockPanel;

    public GameObject ClockOpenButton;

    public GameObject SmallKey;
    public GameObject ClockDoor;

    public void OnClickClockClear1Button()
    {
        //ClockClearPanel1.SetActive(false);
        Destroy(ClockOpenButton);
        SmallKey.gameObject.SetActive(true);
    }

    public void OnClickClockClear2Button()
    {
        ClockClearPanel2.SetActive(false);
        ClockClearPanel3.SetActive(true);
    }

     public void OnClickClockClear3Button()
    {
        ClockClearPanel3.SetActive(false);
        Destroy(ClockOpenButton);
        ClockPanel.SetActive(true);
        SmallKey.gameObject.SetActive(true);
        ClockDoor.gameObject.SetActive(false);
    }
}
