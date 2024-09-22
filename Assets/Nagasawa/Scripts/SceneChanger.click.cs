using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectClickSceneChanger : MonoBehaviour
{
    // 遷移するシーン名
    public string sceneName;

    // オブジェクトがクリックされたときに呼ばれる
    void OnMouseDown()
    {
        // シーン遷移を実行
        SceneManager.LoadScene(sceneName);
    }
}
