using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    public GameObject SettingPanel;
    public GameObject SlidersBackPanel;
    public void OnClickSettingButton()
    {
        SettingPanel.SetActive(true);
        SlidersBackPanel.SetActive(true);
    }
   
}
