using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class DancingFlowerUsage : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject[] DancingFlowerButtonList;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //Rayが判定したとき
            if (Physics.Raycast(ray, out hit))
            {   
                Debug.Log("あ");
                //オブジェクトが特定のnameを持つとき
                if(hit.collider.name=="DancingFlower" && ItemManager.Instance.itemNameList.Contains("完全ブラックライト"))
                {
                    //実行したい処理
                    DancingFlowerButtonList[0].SetActive(true);
                }
            }
        }
    }
}
