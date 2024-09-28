using UnityEngine;

public class Safe : MonoBehaviour
{
    public string password1 = "1234";
    public string password2 = "abcd";
    public Camera mainCamera;
    private string inputPassword = "";
    
    // ドアのフィールドを追加
    public GameObject door1; // パスワード1で開くドア
    public GameObject door2; // パスワード2で開くドア

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // マウスの左ボタンが押されたとき
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Raycast hit: " + hit.collider.name); // ヒットしたオブジェクトの名前を表示
                if (hit.collider != null)
                {
                    if (hit.collider.CompareTag("PasswordButton"))
                    {
                        // ボタン名から数字を取得
                        string buttonName = hit.collider.gameObject.name;
                        if (buttonName.StartsWith("text"))
                        {
                            string number = buttonName.Substring(4); // "text"の後の部分を取得
                            inputPassword += number; // パスワードに追加
                            Debug.Log("Current Input: " + inputPassword);
                        }
                    }
                    else if (hit.collider.CompareTag("EnterButton"))
                    {
                        // Enterボタンがクリックされた場合
                        CheckPassword();
                    }
                    else if (hit.collider.CompareTag("DeleteButton"))
                    {
                        // Deleteボタンがクリックされた場合
                        DeleteLastCharacter();
                    }
                }
            }
            else
            {
                Debug.Log("Raycast did not hit anything.");
            }
        }
    }

    private void CheckPassword()
    {
        if (inputPassword == password1)
        {
            OpenDoor(1);
        }
        else if (inputPassword == password2)
        {
            OpenDoor(2);
        }
        else
        {
            Debug.Log("Incorrect Password");
        }

        // 入力をリセット
        inputPassword = "";
    }

    private void DeleteLastCharacter()
    {
        if (inputPassword.Length > 0)
        {
            inputPassword = inputPassword.Substring(0, inputPassword.Length - 1); // 最後の文字を削除
            Debug.Log("Current Input after Delete: " + inputPassword);
        }
    }

    private void OpenDoor(int doorNumber)
    {
        Debug.Log("Door " + doorNumber + " opened!");
        // 扉を開くアニメーションや処理
        if (doorNumber == 1)
        {
            door1.SetActive(false); // ドア1を非アクティブにする
        }
        else if (doorNumber == 2)
        {
            door2.SetActive(false); // ドア2を非アクティブにする
        }
    }
}
