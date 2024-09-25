using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item itemPrefab; // プレハブとしてのアイテム

    private void OnMouseDown()
    {
        // itemPrefabがnullでないか確認
        if (itemPrefab != null)
        {
            // アイテムを取得
            Item newItem = Instantiate(itemPrefab);
            newItem.OnMouseDown(); // クリックイベントを呼び出す
        }
        else
        {
            Debug.LogError("itemPrefabが設定されていません！"); // エラーメッセージを表示
        }
    }
}

