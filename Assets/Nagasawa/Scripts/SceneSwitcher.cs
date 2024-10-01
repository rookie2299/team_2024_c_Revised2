using UnityEngine;
using UnityEngine.SceneManagement; // シーンマネージメントのための名前空間

public class SceneSwitcher : MonoBehaviour
{
    // 遷移するシーンの名前
    public string sceneName;

    // ボタンを押したときに呼び出すメソッド
    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName); // シーンをロード
    }
}
