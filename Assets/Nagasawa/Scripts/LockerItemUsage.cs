using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class LockerItemUsage : MonoBehaviour
{
    public Camera LockerCamera;
    public GameObject[] LockerButtonList;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = LockerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //Rayが判定したとき
            if (Physics.Raycast(ray, out hit) && hit.collider.name=="Locker")
            {   
                Debug.Log("あ");
                //オブジェクトが特定のnameを持つとき
                if(ItemManager.Instance.itemNameList.Contains("text3"))
                {
                    //実行したい処理
                    LockerButtonList[0].SetActive(true);
                }

                if(ItemManager.Instance.itemNameList.Contains("text5"))
                {
                    //実行したい処理
                    LockerButtonList[1].SetActive(true);
                }

                if(ItemManager.Instance.itemNameList.Contains("text7"))
                {
                    //実行したい処理
                    LockerButtonList[2].SetActive(true);
                }

                if(ItemManager.Instance.itemNameList.Contains("Enter"))
                {
                    //実行したい処理
                    LockerButtonList[3].SetActive(true);
                }
            }
        }
    }
}
