using UnityEngine;

public class ControlChildVisibility : MonoBehaviour
{
    // 子オブジェクトを指定するための変数
    public GameObject childObject;

    void Start()
    {
        // 親オブジェクトのRendererを無効化（見た目を非表示にする）
        Renderer parentRenderer = GetComponent<Renderer>();
        if (parentRenderer != null)
        {
            parentRenderer.enabled = false; // 親オブジェクトを非表示にする
        }

        // 親オブジェクトのColliderを無効化（当たり判定を無効にする）
        Collider parentCollider = GetComponent<Collider>();
        if (parentCollider != null)
        {
            parentCollider.enabled = false; // 親オブジェクトのコライダーを無効化する
        }

        // 子オブジェクトを有効化（表示する）
        if (childObject != null)
        {
            childObject.SetActive(true); // 子オブジェクトが非アクティブならアクティブ化
        }
    }
}
