using UnityEngine;
using UnityEngine.EventSystems;

public class ItemCombiner : MonoBehaviour
{
    public Camera mainCamera;
    bool isBlackLight = false;

    private void Update()
    {
        // ItemManagerのインスタンスにアクセス
        if (ItemManager.Instance.itemNameList.Contains("ブラックライト（電池なし）") && 
            ItemManager.Instance.itemNameList.Contains("電池1") && 
            ItemManager.Instance.itemNameList.Contains("電池2") &&
            !isBlackLight)
        {
            ItemManager.Instance.itemNameList.Add("完全ブラックライト");
            isBlackLight = true;
        }
    }
}
