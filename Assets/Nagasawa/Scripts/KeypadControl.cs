using TMPro;
using UnityEngine;

public class KeypadControl : MonoBehaviour
{
    public TMP_InputField inputField; // TMP_InputFieldの参照

    // 数字ボタンがクリックされたときに呼ばれる
    public void OnNumberButtonClick(string number)
    {
        inputField.text += number; // 数字を追加
    }

    // エンター ボタンがクリックされたときに呼ばれる
    public void OnEnterButtonClick()
    {
        FindObjectOfType<SafeController>().CheckPassword(); // パスワードをチェック
    }

    // デリート ボタンがクリックされたときに呼ばれる
    public void OnDeleteButtonClick()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1); // 文字を削除
        }
    }
}
