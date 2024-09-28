using UnityEngine;
using UnityEngine.UI;

public class ObjectClickTransition : MonoBehaviour
{
    public Transform cameraTransform; // カメラのTransform
    public Vector3 originalPosition;  // 元のカメラ位置
    public Quaternion originalRotation; // 元のカメラ回転
    public Transform[] targetCameraPositions; // オブジェクトに対応するカメラのポジション
    public float transitionSpeed = 2.0f; // 遷移スピード
    public Button returnButton; // 戻るボタン (UI)
    public GameObject mainPanel;

    private bool isTransitioning = false; // 遷移中かどうか
    private Vector3 targetPosition; // 目的地のカメラポジション
    private Quaternion targetRotation; // 目的地のカメラ回転

    void Start()
    {
        // 最初に元の位置と回転を保存
        originalPosition = cameraTransform.position;
        originalRotation = cameraTransform.rotation;

        // 戻るボタンを非表示に設定
        returnButton.gameObject.SetActive(false);

        // ボタンのクリックイベントにメソッドを登録
        returnButton.onClick.AddListener(ReturnToOriginalPosition);
    }

    void Update()
    {
        // オブジェクトをクリックする処理
        if (Input.GetMouseButtonDown(0) && !isTransitioning)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                for (int i = 0; i < targetCameraPositions.Length; i++)
                {
                    // オブジェクトに対応するカメラポジションへ遷移
                    if (hit.transform == targetCameraPositions[i].transform)
                    {
                        StartTransition(targetCameraPositions[i].position, targetCameraPositions[i].rotation);
                        // ボタンを表示
                        returnButton.gameObject.SetActive(true);
                        mainPanel.SetActive(true);
                    }
                }
            }
        }

        // カメラが目的地に向かって遷移中
        if (isTransitioning)
        {
            cameraTransform.position = Vector3.Lerp(cameraTransform.position, targetPosition, Time.deltaTime * transitionSpeed);
            cameraTransform.rotation = Quaternion.Lerp(cameraTransform.rotation, targetRotation, Time.deltaTime * transitionSpeed);

            // 目的地に近づいたら遷移を終了
            if (Vector3.Distance(cameraTransform.position, targetPosition) < 0.1f)
            {
                isTransitioning = false;
            }
        }
    }

    // 遷移を開始する
    void StartTransition(Vector3 position, Quaternion rotation)
    {
        targetPosition = position;
        targetRotation = rotation;
        isTransitioning = true;
    }

    // 戻るボタンをクリックした際に呼び出されるメソッド
    public void ReturnToOriginalPosition()
    {
        StartTransition(originalPosition, originalRotation);
        // ボタンを非表示に設定
        returnButton.gameObject.SetActive(false);
    }
}
