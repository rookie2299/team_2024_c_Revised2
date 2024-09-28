using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class DancingFlowerUsage : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject[] DancingFlowerButtonList;
    public Collider targetCollider;

    public CameraPosition cameraPosition; // CameraPositionのインスタンスを保持

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
                if(hit.collider.name=="text7Manager" && ItemManager.Instance.itemNameList.Contains("完全ブラックライト") && cameraPosition.isZoom)
                {
                    //実行したい処理
                    Debug.LogWarning("認識");
                    DancingFlowerButtonList[0].SetActive(true);
                    targetCollider.enabled = !targetCollider.enabled;
                }
            }
        }
    }
}