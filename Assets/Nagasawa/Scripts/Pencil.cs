using UnityEngine;

public class Pencil : MonoBehaviour
{
    private bool isBattery = false;

    private void Update()
    {
        // 両方のアイテムが存在し、まだ電池が追加されていない場合
        if (ItemManager.Instance.itemNameList.Contains("電池1(使用不可)") && 
            ItemManager.Instance.itemNameList.Contains("鉛筆") && 
            !isBattery)
        {
            // "電池1"をアイテムリストに追加
            ItemManager.Instance.itemNameList.Add("電池1");
            isBattery = true; // フラグをtrueにして、今後の追加を防ぐ
        }
    }
}
