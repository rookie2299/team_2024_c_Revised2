using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnobOpen : MonoBehaviour
{
    public Vector3 openPosition;  // 引き出しが開いたときの位置
    public Vector3 closedPosition; // 引き出しが閉じたときの位置
    public float speed = 1.0f;     // 開け閉めのスピード

    private bool isOpen = false;   // 現在の状態

    void Start()
    {
        // 初期位置を設定
        transform.localPosition = closedPosition;
    }

    void OnMouseDown() // マウスクリックを検出
    {
        ToggleDrawer();
    }

    public void ToggleDrawer()
    {
        if (isOpen)
            StartCoroutine(MoveDrawer(closedPosition));
        else
            StartCoroutine(MoveDrawer(openPosition));

        isOpen = !isOpen;
    }

    private IEnumerator MoveDrawer(Vector3 targetPosition)
    {
        while (Vector3.Distance(transform.localPosition, targetPosition) > 0.01f)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);
            yield return null; // 次のフレームまで待機
        }

        // 最終的に位置を確定
        transform.localPosition = targetPosition;
    }
}
