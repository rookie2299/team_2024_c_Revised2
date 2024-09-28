using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement; // シーン管理用の名前空間を追加

public class ClockSetting : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject Clock;
    public GameObject Clockright;

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
                if(hit.collider.name == "Clock" && ItemManager.Instance.itemNameList.Contains("ドライバー本体"))
                {
                    // 実行したい処理
                   Clock.SetActive(false);
                   Clockright.SetActive(true);
                }
            }
        }
    }
}
