using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item itemPrefab; // プレハブとしてのアイテム

    private void OnMouseDown()
    {
        // アイテムを取得
        Item newItem = Instantiate(itemPrefab);
        newItem.OnMouseDown(); // クリックイベントを呼び出す
    }
}
