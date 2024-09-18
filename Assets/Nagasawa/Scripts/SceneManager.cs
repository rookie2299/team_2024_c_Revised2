using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    // シーンをロードするためのメソッド
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // 特定のシーン番号でシーンをロードするためのメソッド
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // 現在のシーンをリロードするためのメソッド
    public void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    // 遷移時のフェードイン・アウト処理（オプション）
    public IEnumerator LoadSceneWithFade(string sceneName, Animator animator)
    {
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1.0f); // フェードアウトの時間を待機
        SceneManager.LoadScene(sceneName);
    }
}
