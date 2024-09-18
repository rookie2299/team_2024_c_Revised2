using UnityEngine;
using TMPro; // TextMeshProの名前空間をインポート

public class KeypadButton : MonoBehaviour
{
    public TMP_InputField inputField; // TMP_InputFieldを使用

    public void OnButtonClick(string number)
    {
        inputField.text += number; // 数字を追加
    }
}
