using UnityEngine;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }
    private List<Item> itemList = new List<Item>();
    public List<string> itemNameList = new List<string>(); 

    public GameObject targetObject; // SetActiveにするオブジェクト
    public List<string> requiredItems = new List<string> { "ItemA", "ItemB" }; // 必要なアイテムのリスト

    private bool hasLoggedNullWarning = false; // 警告を一度だけ出すためのフラグ

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
        Debug.LogWarning("Item is being added.");
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

    void Update()
    {
        CheckItems();
    }

    private void CheckItems()
    {
        // targetObjectがnullでないかチェック
        if (targetObject == null)
        {
            if (!hasLoggedNullWarning) // 警告を一度だけ出す
            {
                Debug.LogWarning("targetObject is null. Please assign a valid GameObject.");
                hasLoggedNullWarning = true; // 警告を出したフラグを立てる
            }
            return; // nullの場合は処理を中断
        }
        else
        {
            hasLoggedNullWarning = false; // targetObjectが有効な場合はフラグをリセット
        }

        bool hasRequiredItems = true;

        // 必要なアイテムが全てあるか確認
        foreach (var itemName in requiredItems)
        {
            if (!itemList.Exists(item => item.itemName == itemName))
            {
                hasRequiredItems = false;
                break;
            }
        }

        // オブジェクトのアクティブ状態を設定
        targetObject.SetActive(hasRequiredItems);
    }
}
