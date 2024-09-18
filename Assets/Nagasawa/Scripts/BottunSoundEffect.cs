using UnityEngine;

public class ButtonSoundEffect : MonoBehaviour
{
    // SEとして再生するAudioClipをインスペクタで設定
    public AudioClip buttonClickSound;  // ここでAudioClipを宣言
    
    private AudioSource audioSource;

    void Start()
    {
        // AudioSourceを取得、またはコンポーネントを追加
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // ボタンがクリックされたときに呼び出されるメソッド
    public void PlaySound()
    {
        // AudioClipを再生
        if (buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound);  // ここでAudioClipを再生
        }
        else
        {
            Debug.LogWarning("ボタンクリックサウンドが設定されていません。");
        }
    }
}
