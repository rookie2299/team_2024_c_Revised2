using UnityEngine;
using TMPro;  // TextMeshProを使用するため

public class KeypadControl : MonoBehaviour
{
    public GameObject keypadUI;              // キーパッドのUI
    public TMP_InputField inputDisplay;      // 入力表示用のInput Field
    public string correctCode1 = "1234";     // 正しいパスコード1
    public string correctCode2 = "5678";     // 正しいパスコード2
    public GameObject door1;                 // 扉1
    public GameObject door2;                 // 扉2
    private string enteredCode = "";         // 入力されたパスコード

    // キーパッドを表示するメソッド
    public void OpenKeypad()
    {
        if (!keypadUI.activeSelf)  // キーパッドUIが非表示の場合のみリセット
        {
            enteredCode = "";      // 入力コードをリセット
            inputDisplay.text = "";  // 表示をリセット
        }
        keypadUI.SetActive(true);  // キーパッドUIを表示
    }

    // キーパッドの数字ボタンを押したときに呼び出されるメソッド
    public void AddDigit(string digit)
    {
        if (enteredCode.Length < 4)  // 最大4桁まで
        {
            enteredCode += digit;  // 入力された数字を追加
            inputDisplay.text = enteredCode;  // InputFieldに入力を反映
        }
    }

    // デリートボタンを押したときに呼び出されるメソッド
    public void DeleteDigit()
    {
        if (enteredCode.Length > 0)
        {
            enteredCode = enteredCode.Substring(0, enteredCode.Length - 1);
            inputDisplay.text = enteredCode;
        }
    }

    // エンターボタンを押したときに呼び出されるメソッド
    public void EnterCode()
    {
        if (enteredCode == correctCode1)
        {
            OpenDoor(door1);  // 扉1を開く
            CloseKeypad();    // キーパッドを閉じる
        }
        else if (enteredCode == correctCode2)
        {
            OpenDoor(door2);  // 扉2を開く
            CloseKeypad();    // キーパッドを閉じる
        }
        else
        {
            inputDisplay.text = "Error";  // エラーメッセージを表示
        }
        enteredCode = "";  // 入力コードをリセット
    }

    // 扉を開けるメソッド
    void OpenDoor(GameObject door)
    {
        door.SetActive(false);  // 扉を非表示にする
        Debug.Log("Door opened: " + door.name);
    }

    // キーパッドを閉じるメソッド
    public void CloseKeypad()
    {
        keypadUI.SetActive(false);  // キーパッドUIを非表示
        enteredCode = "";           // 入力コードをリセット
        inputDisplay.text = "";     // 表示をリセット
    }

    // 金庫をクリックしたときに呼び出されるメソッド
    void OnMouseDown()
    {
        Debug.Log("Safe clicked");  // デバッグ用
        OpenKeypad();  // キーパッドを表示
    }
}
