using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;

    // これを public に変更します
    public void OnMouseDown()
    {
        // アイテムがクリックされたときの処理
        ItemManager.Instance.AddItemToList(this);
        Destroy(gameObject); // アイテムをシーンから削除
    }
}
