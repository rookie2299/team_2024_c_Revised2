using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class PhotoDriver : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject[] PhotoDriverList;

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
                if(hit.collider.name=="写真立て" && ItemManager.Instance.itemNameList.Contains("ドライバー"))
                {
                    PhotoDriverList[0].SetActive(true);
                    PhotoDriverList[1].SetActive(true);
                    PhotoDriverList[2].SetActive(true);
                }
            }
        }
    }
}
