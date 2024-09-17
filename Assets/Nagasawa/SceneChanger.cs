using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // 別のシーンをロード
    public void SwitchToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
