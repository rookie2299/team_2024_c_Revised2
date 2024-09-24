using UnityEngine;
using System.Collections.Generic;

public class EscapeTrigger : MonoBehaviour
{
    // 脱出に必要なアイテム名のリストのリスト
    public List<List<string>> requiredItems = new List<List<string>> 
    {
        new List<string> { "鍵", "メモ" },
        new List<string> { "ドライバー", "パスワード" }
    };

    private void OnMouseDown()
    {
        string result = ItemManager.Instance.CanEscape(requiredItems);
        Debug.Log(result);
        // 脱出の処理をここに追加
    }
}
