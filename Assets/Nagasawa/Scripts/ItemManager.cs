using UnityEngine;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }
    private List<Item> itemList = new List<Item>();
    public List<string> itemNameList = new List<string>(); 

    void Awake()
    {
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

    public void AddItemToList(Item item)
    {   
        Debug.LogWarning("a");
        itemList.Add(item);
        itemNameList.Add(item.itemName);
        Debug.Log(item.itemName + " has been added to the list.");
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }

    public string CanEscape(List<List<string>> requiredItems)
    {
        foreach (var requiredList in requiredItems)
        {
            bool canEscape = true;
            foreach (var requiredItem in requiredList)
            {
                if (!itemList.Exists(item => item.itemName == requiredItem))
                {
                    canEscape = false; // 必要なアイテムがなければ脱出できない
                    break;
                }
            }
            if (canEscape)
            {
                return "You can escape with items: " + string.Join(", ", requiredList);
            }
        }
        return "You need more items to escape.";
    }
}
