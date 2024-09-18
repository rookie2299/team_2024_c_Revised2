using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider bgmSlider; // BGMのスライダー
    public Slider seSlider;  // SEのスライダー

    public AudioSource bgmSource; // BGM用のAudioSource
    public AudioSource seSource;  // SE用のAudioSource

    void Start()
    {
        // 保存された設定を読み込み
        bgmSlider.value = PlayerPrefs.GetFloat("bgmVolume", 1f);
        seSlider.value = PlayerPrefs.GetFloat("seVolume", 1f);

        // リスナーの登録
        bgmSlider.onValueChanged.AddListener(SetBGMVolume);
        seSlider.onValueChanged.AddListener(SetSEVolume);

        // 初期音量の設定
        SetBGMVolume(bgmSlider.value);
        SetSEVolume(seSlider.value);
    }

    // BGMの音量を設定
    public void SetBGMVolume(float volume)
    {
        bgmSource.volume = volume;
        PlayerPrefs.SetFloat("bgmVolume", volume); // 設定を保存
    }

    // SEの音量を設定
    public void SetSEVolume(float volume)
    {
        seSource.volume = volume;
        PlayerPrefs.SetFloat("seVolume", volume); // 設定を保存
    }
}
