using UnityEngine;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }

    private List<Item> itemList = new List<Item>();

    void Awake()
    {
        // シングルトンパターンの設定
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // アイテムをリストに追加
    public void AddItemToList(Item item)
    {
        itemList.Add(item);
        Debug.Log(item.itemName + " has been added to the list.");
    }

    // アイテムリストを取得
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
