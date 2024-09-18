using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcherUI : MonoBehaviour
{
    public Camera[] cameras; // 4つのカメラをアサインする
    private int currentCameraIndex = 0; // 現在のカメラインデックス

    public Button leftButton; // 左ボタン
    public Button rightButton; // 右ボタン

    void Start()
    {
        // 最初のカメラ以外のカメラを無効化する
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        // カメラが正しく設定されているか確認
        if (cameras.Length > 0)
        {
            cameras[0].gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("カメラが設定されていません。");
        }

        // ボタンにイベントを追加
        leftButton.onClick.AddListener(() => SwitchCamera(-1));
        rightButton.onClick.AddListener(() => SwitchCamera(1));
    }

    private void SwitchCamera(int direction)
    {
        // 現在のカメラを無効化
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // 次のカメラを選択
        currentCameraIndex = (currentCameraIndex + direction + cameras.Length) % cameras.Length;

        // 次のカメラを有効化
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}