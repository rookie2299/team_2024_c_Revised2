using UnityEngine;
using UnityEngine.EventSystems;

public class Knob : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject[] KnobList;        // ノブのリスト
    public GameObject driverHandle;      // ドライバー持ち手のオブジェクト

    private void OnMouseDown()
    {
        // 左クリック時かつUIの上でないことを確認
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // レイキャストが何かにヒットしたとき
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("レイキャストヒット: " + hit.collider.name);

                // ヒットしたオブジェクトが「隠し引き出し」で、ドライバー持ち手がリストに含まれている場合
                if (hit.collider.name == "隠し引き出し" && ItemManager.Instance.itemNameList.Contains("ドライバー持ち手"))
                {
                    Debug.Log("条件を満たしました。Knobを表示し、ドライバー持ち手を有効化します。");

                    // Knobの表示
                    KnobList[0].SetActive(true);

                    // ドライバー持ち手のRendererを有効化（表示する）
                    Renderer driverRenderer = driverHandle.GetComponent<Renderer>();
                    if (driverRenderer != null)
                    {
                        driverRenderer.enabled = true;
                        Debug.Log("ドライバー持ち手のRendererを有効化しました。");
                    }

                    // ドライバー持ち手のColliderを有効化（当たり判定を有効にする）
                    Collider driverCollider = driverHandle.GetComponent<Collider>();
                    if (driverCollider != null)
                    {
                        driverCollider.enabled = true;
                        Debug.Log("ドライバー持ち手のColliderを有効化しました。");
                    }
                }
            }
        }
    }
}
