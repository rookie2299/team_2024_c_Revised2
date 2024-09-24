using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>(); // 所持アイテムのリスト

    // アイテムを追加
    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log(item.itemName + " has been added to inventory.");
    }

    // アイテムを取得
    public Item GetItem(string itemName)
    {
        return items.Find(item => item.itemName == itemName);
    }

    // アイテムが存在するか確認
    public bool HasItem(string itemName)
    {
        return items.Exists(item => item.itemName == itemName);
    }
}
