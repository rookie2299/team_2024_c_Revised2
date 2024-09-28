using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidersClose : MonoBehaviour
{
    public GameObject SettingPanel;
    public GameObject SlidersBackPanel;

    public void OnClickSlidersCloseButton()
    {
        SettingPanel.SetActive(false);
        SlidersBackPanel.SetActive(false);
    }
}
