using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリック
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Item item = hit.transform.GetComponent<Item>();

                if (item != null)
                {
                    item.OnMouseDown(); // アイテムを選択
                }
            }
        }
    }
}

