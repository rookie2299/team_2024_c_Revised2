using UnityEngine;
using TMPro; // TextMeshProの名前空間をインポート

public class SafeController : MonoBehaviour
{
    public GameObject keypadUI;      // キーパッドのUI
    public string correctPassword = "1234"; // 正しいパスワード
    public TMP_InputField inputField;    // パスワード入力用のTMP_InputField
    public GameObject safeDoor;      // 金庫のドア（開閉用）

    private bool isKeypadActive = false;

    // Cubeがクリックされた時に呼ばれる
    void OnMouseDown()
    {
        if (!isKeypadActive)
        {
            ShowKeypad(); // キーパッドを表示
        }
    }

    // キーパッドを表示
    void ShowKeypad()
    {
        Debug.Log("ShowKeypad called"); // デバッグログを追加
        keypadUI.SetActive(true); // キーパッドUIを表示
        isKeypadActive = true; // キーパッドがアクティブ状態であることを設定
    }

    // パスワードのチェック
    public void CheckPassword()
    {
        if (inputField.text == correctPassword)
        {
            OpenSafe();
        }
        else
        {
            Debug.Log("Wrong password");
        }
    }

    // 金庫を開ける処理
    void OpenSafe()
    {
        Debug.Log("Safe opened!");
        // ドアを開けるアニメーション等をここに記述
        safeDoor.transform.Rotate(0, 90, 0); // 例：ドアを90度回転させて開ける
        keypadUI.SetActive(false); // キーパッドを隠す
        isKeypadActive = false;
    }

    // キーパッドを閉じる
    public void CloseKeypad()
    {
        keypadUI.SetActive(false);
        isKeypadActive = false;
    }
}
