using UnityEngine;

public class DancingFlowerGetting : MonoBehaviour
{
    // 変更するコライダーへの参照
    public Collider targetCollider;

    // コライダーの状態を切り替えるメソッド
    public void ToggleCollider()
    {
        if (targetCollider != null && ItemManager.Instance.itemNameList.Contains("text7"))
        {
            // コライダーの表示/非表示を切り替える
            targetCollider.enabled = !targetCollider.enabled;
        }
    }
}
