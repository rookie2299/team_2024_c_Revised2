using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement; // シーン管理用の名前空間を追加

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
                if(hit.collider.name == "door" && ItemManager.Instance.itemNameList.Contains("key(door)"))
                {
                    // 実行したい処理
                    if (ItemManager.Instance.itemNameList.Contains("DancingFlower") && ItemManager.Instance.itemNameList.Contains("日記帳") && !ItemManager.Instance.itemNameList.Contains("香水") && !ItemManager.Instance.itemNameList.Contains("お札"))
                    {
                        // 特定のアイテムが揃っている場合のシーン遷移
                        SceneManager.LoadScene("Ayamati"); // シーン名を指定して遷移
                        Debug.Log("過ち");
                    }
                    else if (ItemManager.Instance.itemNameList.Contains("香水") && ItemManager.Instance.itemNameList.Contains("お札") && !ItemManager.Instance.itemNameList.Contains("DancingFlower") && !ItemManager.Instance.itemNameList.Contains("日記帳"))
                    {
                        // 別のアイテムが揃っている場合のシーン遷移
                        SceneManager.LoadScene("Kyokou"); // 別のシーンに遷移
                        Debug.Log("虚構");
                    }
                    else
                    {
                        // 条件に合わない場合のシーン遷移
                        SceneManager.LoadScene("Boukyaku"); // デフォルトのシーンに遷移
                        Debug.Log("忘却");
                    }
                }
            }
        }
    }
}
