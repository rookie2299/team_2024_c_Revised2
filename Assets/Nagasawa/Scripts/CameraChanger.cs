using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    public Camera targetCamera; // 遷移するターゲットのカメラ
    public Camera currentCamera; // 現在のカメラ
    public GameObject mainPanel;
    public GameObject backButton;

    void Start()
    {
        // 現在のカメラが指定されていない場合、シーンのMain Cameraを使う
        if (currentCamera == null)
        {
            currentCamera = Camera.main;
        }

        // 最初にターゲットカメラを無効にする
        targetCamera.gameObject.SetActive(false);
    }

    void Update()
    {
        // オブジェクトがクリックされたかを確認
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = currentCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                // クリックされたオブジェクトがこのオブジェクトか確認
                if (hit.transform == transform)
                {
                    // カメラを切り替える
                    SwitchCamera();
                    mainPanel.SetActive(false);
                }
            }
        }
    }

    void SwitchCamera()
    {
        // 現在のカメラを無効にし、ターゲットカメラを有効にする
        currentCamera.gameObject.SetActive(false);
        targetCamera.gameObject.SetActive(true);
        backButton.SetActive(true);
    }
}
