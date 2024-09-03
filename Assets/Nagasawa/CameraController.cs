using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Buttonコンポーネントを使用するために追加

public class CameraController : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;
    public Camera Camera4;

    // ボタンUIをインスペクタで設定
    public Button switchButton;

    private int currentCameraIndex;

    // Start is called before the first frame update
    void Start()
    {
        // 最初にCamera1をアクティブにし、他のカメラを非アクティブにする
        currentCameraIndex = 0;
        ActivateCamera(currentCameraIndex);

        // ボタンのクリックイベントにリスナーを追加
        switchButton.onClick.AddListener(SwitchCamera);
    }

    void SwitchCamera()
    {
        // カメラを次のものに切り替える
        currentCameraIndex = (currentCameraIndex + 1) % 4; // カメラのインデックスを循環させる
        ActivateCamera(currentCameraIndex);
    }

    void ActivateCamera(int index)
    {
        // すべてのカメラを一度非アクティブにする
        Camera1.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(false);
        Camera3.gameObject.SetActive(false);
        Camera4.gameObject.SetActive(false);

        // 指定されたインデックスのカメラをアクティブにする
        switch (index)
        {
            case 0:
                Camera1.gameObject.SetActive(true);
                break;
            case 1:
                Camera2.gameObject.SetActive(true);
                break;
            case 2:
                Camera3.gameObject.SetActive(true);
                break;
            case 3:
                Camera4.gameObject.SetActive(true);
                break;
            default:
                Debug.LogWarning("Invalid camera index");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Updateメソッドは現在必要ありません
    }
}
