using UnityEngine;

public class ItemUsageTrigger : MonoBehaviour
{
    public Inventory playerInventory; // プレイヤーのインベントリを参照

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリックの確認
        {
            if (playerInventory.HasItem("Key")) // キーがある場合の処理
            {
                Debug.Log("Door opened using the key!");
                // ドアを開く処理
            }
            else
            {
                Debug.Log("You need a key to open this door.");
            }
        }
    }
}
