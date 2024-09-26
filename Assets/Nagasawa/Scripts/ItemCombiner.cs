using UnityEngine;
using UnityEngine.EventSystems;

public class ItemCombiner : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject BlackLight;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Rayが判定したとき
            if (Physics.Raycast(ray, out hit))
            {   
                // ItemManagerのインスタンスにアクセス
                if (ItemManager.Instance.itemNameList.Contains("ブラックライト（電池なし）") && 
                    ItemManager.Instance.itemNameList.Contains("電池1") && 
                    ItemManager.Instance.itemNameList.Contains("電池2"))
                {
                    BlackLight.SetActive(true);
                }
            }
        }
    }
}
