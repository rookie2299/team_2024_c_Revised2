using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class BoxOpenTrigger : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject[] BoxOpenList;
    public Camera targetCamera;
    public Camera currentCamera;

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
                if(hit.collider.name=="box" && ItemManager.Instance.itemNameList.Contains("key(box)"))
                {
                    //実行したい処理
                    BoxOpenList[0].SetActive(false);
                    BoxOpenList[1].SetActive(false);
                    BoxOpenList[2].SetActive(false);
                    SwitchCamera();
                 
                    void SwitchCamera()
                    {
                        // 現在のカメラを無効にし、ターゲットカメラを有効にする
                        currentCamera.gameObject.SetActive(false);
                        targetCamera.gameObject.SetActive(true);
                    }
                }
             }
         }
     }
}

