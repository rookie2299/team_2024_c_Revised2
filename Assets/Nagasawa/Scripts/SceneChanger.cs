using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // 遷移したいシーンの名前
    public string sceneName;

    // シーンを変更するメソッド
    public void ChangeScene()
    {
        // SceneManagerを使って指定されたシーンをロード
        SceneManager.LoadScene(sceneName);
    }
}
