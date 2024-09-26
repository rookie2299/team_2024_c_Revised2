using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class DancingFlowerGetting : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject DancingFlower;
    bool isDancingFlower = false;

    private void Update()
    {
                if(ItemManager.Instance.itemNameList.Contains("text7") && !isDancingFlower)
                {
                    ItemManager.Instance.itemNameList.Add("DancingFlower");
                    isDancingFlower = true;
                    DancingFlower.SetActive(false);
                }
    }
}