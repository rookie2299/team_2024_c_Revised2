using UnityEngine;
using System.Collections.Generic;

public class ItemCombiner : MonoBehaviour
{
    public List<string> itemsToCombine = new List<string> { "ItemA", "ItemB", "ItemC" }; // 合成に必要なアイテム名
    public string combinedItemName = "CombinedItem"; // 合成後のアイテム名

    void Update()
    {
        CheckForCombine();
    }

    private void CheckForCombine()
    {
        // プレイヤーのアイテムリストを取得
        var itemList = ItemManager.Instance.GetItemList();
        List<string> currentItemNames = new List<string>();

        foreach (var item in itemList)
        {
            currentItemNames.Add(item.itemName);
        }

        // 合成条件を確認
        if (CanCombine(currentItemNames))
        {
            CombineItems(currentItemNames);
        }
    }

    private bool CanCombine(List<string> currentItemNames)
    {
        // 必要なアイテムが全て存在するか確認
        foreach (string item in itemsToCombine)
        {
            if (!currentItemNames.Contains(item))
            {
                return false; // 一つでも不足している場合、合成不可
            }
        }
        return true; // 全て存在する場合、合成可能
    }

    private void CombineItems(List<string> currentItemNames)
    {
        // 合成処理
        Debug.Log($"合成成功: {combinedItemName} を作成しました。");

        // 新しいアイテムを生成
        Item combinedItem = new GameObject(combinedItemName).AddComponent<Item>();
        combinedItem.itemName = combinedItemName;

        // アイテムをItemManagerに追加
        ItemManager.Instance.AddItemToList(combinedItem);

        // 合成したアイテムをインベントリから削除
        foreach (string item in itemsToCombine)
        {
            var itemToRemove = ItemManager.Instance.GetItemList().Find(i => i.itemName == item);
            if (itemToRemove != null)
            {
                ItemManager.Instance.GetItemList().Remove(itemToRemove);
            }
        }
    }
}
