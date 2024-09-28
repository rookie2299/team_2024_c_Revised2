using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    [System.Serializable]
    public class CameraTarget
    {
        public Transform position; // 移動先のポジション
        public Vector3 rotation;   // 移動先の回転（オイラー角）も追加
    }

    [SerializeField] private CameraTarget midCameraPosition; // ミッドカメラのポジションと回転を保持
    [SerializeField] private List<CameraTarget> targetCameraPositions; // 複数のターゲットポジションと回転を保持
    public GameObject backButton;
    [SerializeField] private Camera mainCamera;
    public List<string> targetNames; // 複数のターゲット名を保持するリスト
    public GameObject mainPanel;
    public bool isZoom = false;

    private Vector3 previousRotation; // 移動前のカメラの回転を保存する変数

    void Start()
    {
        backButton.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリック
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                int index = targetNames.IndexOf(hit.collider.name);

                if (index != -1)
                {
                    previousRotation = mainCamera.transform.eulerAngles; // カメラの回転を保存
                    MoveToTarget(index);
                    backButton.SetActive(true);
                    mainPanel.SetActive(false);
                }
            }
        }
    }

    public void OnclickBackButton()
    {
        // ミッドカメラのポジションと保存した回転位置に戻す
        MoveCameraTo(midCameraPosition.position.position, midCameraPosition.rotation);
        backButton.SetActive(false);
        mainPanel.SetActive(true);
        isZoom = false;
    }

    private void MoveCameraTo(Vector3 targetPosition, Vector3 rotation)
    {
        mainCamera.transform.position = targetPosition;
        mainCamera.transform.rotation = Quaternion.Euler(rotation);
    }

    public void MoveToTarget(int index)
    {
        if (index >= 0 && index < targetCameraPositions.Count)
        {
            isZoom = true;
            // 対象のターゲットポジションと回転にカメラを移動
            MoveCameraTo(targetCameraPositions[index].position.position, targetCameraPositions[index].rotation);
        }
        else
        {
            Debug.LogWarning("指定されたインデックスは範囲外です。");
        }
    }
}