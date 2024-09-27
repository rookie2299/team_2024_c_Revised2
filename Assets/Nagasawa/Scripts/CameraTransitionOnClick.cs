using UnityEngine;

public class CameraTransitionOnClick : MonoBehaviour
{
    [System.Serializable]
    public class CameraTarget
    {
        public Transform position; // 遷移先ポジション
        public Vector3 rotation; // 遷移先回転（オイラー角）
        public GameObject panel; // 遷移時に表示するパネル
    }

    public CameraTarget[] targets; // ターゲットポジション、回転、およびパネルの配列
    public GameObject backButton; // 戻るボタンのUIオブジェクト
    public float transitionSpeed = 2.0f; // 遷移速度
    private Camera mainCamera; // メインカメラ
    private bool isTransitioning = false; // 遷移中かどうか
    private int currentTargetIndex = -1; // 現在のターゲットインデックス
    private int previousTargetIndex = -1; // 前のターゲットインデックス

    void Start()
    {
        mainCamera = Camera.main; // メインカメラを取得
        backButton.SetActive(false); // 初期状態で戻るボタンを非表示にする
        backButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnBackButtonClick); // ボタンにイベント追加

        // 初期状態でパネルも表示する
        foreach (var target in targets)
        {
            if (target.panel != null)
            {
                target.panel.SetActive(true);
            }
        }
    }

    void Update()
    {
        // マウスの左クリックを検出
        if (Input.GetMouseButtonDown(0) && !isTransitioning)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // レイキャストを実行
            if (Physics.Raycast(ray, out hit))
            {
                // クリックされたオブジェクトが指定された場合
                for (int i = 0; i < targets.Length; i++)
                {
                    if (hit.transform.name == targets[i].position.name) // オブジェクト名が一致する場合
                    {
                        previousTargetIndex = currentTargetIndex; // 現在のインデックスを保存
                        StartCoroutine(TransitionToPosition(i));
                        break;
                    }
                }
            }
        }
    }

    public void OnBackButtonClick() // 戻るボタンがクリックされた場合
    {
        // 前のターゲットに戻る
        if (previousTargetIndex >= 0)
        {
            StartCoroutine(TransitionToPosition(previousTargetIndex)); // 前のターゲットに戻る
        }
    }

    private System.Collections.IEnumerator TransitionToPosition(int index)
    {
        if (index < 0 || index >= targets.Length)
            yield break; // インデックスが範囲外の場合は終了

        isTransitioning = true;
        Vector3 targetPosition = targets[index].position.position;
        Quaternion targetRotation = Quaternion.Euler(targets[index].rotation); // 回転をQuaternionに変換

        // 現在のカメラ位置からターゲット位置に遷移
        while (Vector3.Distance(mainCamera.transform.position, targetPosition) > 0.01f || 
               Quaternion.Angle(mainCamera.transform.rotation, targetRotation) > 0.01f)
        {
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, targetPosition, Time.deltaTime * transitionSpeed);
            mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, targetRotation, Time.deltaTime * transitionSpeed);
            yield return null; // フレーム待機
        }

        mainCamera.transform.position = targetPosition; // 最終位置を設定
        mainCamera.transform.rotation = targetRotation; // 最終回転を設定
        isTransitioning = false;

        // 戻るボタンとパネルの表示管理
        currentTargetIndex = index; // 現在のターゲットインデックスを更新
        backButton.SetActive(currentTargetIndex >= 0); // ボタンを表示

        // 対応するパネルの表示管理
        foreach (var target in targets)
        {
            if (target.panel != null)
            {
                target.panel.SetActive(false); // 他のパネルは非表示にする
            }
        }
        if (targets[index].panel != null)
        {
            targets[index].panel.SetActive(false); // 現在のターゲットに対応するパネルを非表示にする
        }
    }
}
