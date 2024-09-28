using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton1 : MonoBehaviour
{
    //オンオフするPanelの宣言
    [SerializeField] private GameObject ItemPanel;
 
 
    public void OpenSettingButton()
    {
        if (ItemPanel.activeSelf)
        {
            //PanelがActive(表示されている）時にPanelを非表示にする
            ItemPanel.SetActive(false);
        }
        else
        {
            //PanelがActiveでない(表示されていない）時にPanelを表示にする
            ItemPanel.SetActive(true);
        }
 
    }
}
