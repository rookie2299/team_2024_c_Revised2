using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public Camera raycastCamera; // 任意のカメラを設定可能

    void Start()
    {
        // raycastCameraが設定されていない場合、デフォルトでCamera.mainを使用
        if (raycastCamera == null)
        {
            raycastCamera = Camera.main;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリック
        {
            if (raycastCamera == null)
            {
                Debug.LogError("Raycast Camera is not set!"); // カメラが設定されていない場合
                return;
            }

            Ray ray = raycastCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.Log("Raycast sent from camera: " + raycastCamera.name); // カメラ名の確認

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Raycast hit: " + hit.transform.name); // ヒットしたオブジェクトの名前を出力
                Item item = hit.transform.GetComponent<Item>();

                if (item != null)
                {
                    item.OnMouseDown(); // アイテムを選択
                    Debug.Log("Item selected: " + item.name); // 選択されたアイテムを確認
                }
                else
                {
                    Debug.Log("Hit object is not an Item."); // ヒットしたオブジェクトがItemでない場合
                }
            }
            else
            {
                Debug.Log("Raycast did not hit anything."); // レイが何もヒットしなかった場合
            }
        }
    }
}
