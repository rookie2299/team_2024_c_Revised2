using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class ItemUsageTrigger : MonoBehaviour
{
    public Camera mainCamera;

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
                if(hit.collider.name=="door" && ItemManager.Instance.itemNameList.Contains("key"))
                {
                    //実行したい処理
                    Debug.LogWarning("脱出");
                }
            }
        }
    }
}
