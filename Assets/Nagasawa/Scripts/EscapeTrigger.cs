using UnityEngine;
using UnityEngine.SceneManagement; // シーン管理に必要
using System.Collections.Generic;  // Listを使用するために追加

public class EscapeTrigger : MonoBehaviour
{
    // 脱出に必要なアイテム名のリストのリスト
    public List<List<string>> requiredItems = new List<List<string>> 
    {
        new List<string> { "メモ18", "メモ53" },
        new List<string> { "ドライバー", "パスワード" }
    };

    public string nextSceneName = "EscapeCompleteScene"; // 次に移動するシーンの名前

    private void OnMouseDown()
    {
        string result = ItemManager.Instance.CanEscape(requiredItems); // アイテムの確認
        Debug.Log(result);

        if (result == "Escape Successful") // 必要なアイテムが揃った場合
        {
            // シーンを切り替えて脱出成功
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log("Not all required items are collected."); // アイテムが足りない場合の処理
        }
    }
}
