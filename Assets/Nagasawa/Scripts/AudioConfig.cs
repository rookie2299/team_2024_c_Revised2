using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioConfig : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] AudioSource seAudioSource;
    [SerializeField] AudioSource bgmAudioSource;
    [SerializeField] Slider seSlider;
    [SerializeField] Slider bgmSlider;

    private void Start()
    {
        // BGMスライダーの値が変更されたときに呼ばれるメソッドを設定
        bgmSlider.onValueChanged.AddListener((value) =>
        {
            value = Mathf.Clamp01(value);
            // -80から0の間のデシベルに変換
            float decibel = Mathf.Log10(value) * 20f;
            decibel = Mathf.Clamp(decibel, -80f, 0f);
            audioMixer.SetFloat("BGM", decibel);
        });

        // SEスライダーの値が変更されたときに呼ばれるメソッドを設定
        seSlider.onValueChanged.AddListener((value) =>
        {
            value = Mathf.Clamp01(value);
            // -80から0の間のデシベルに変換
            float decibel = Mathf.Log10(value) * 20f;
            decibel = Mathf.Clamp(decibel, -80f, 0f);
            audioMixer.SetFloat("SE", decibel);
        });
    }

    void Update()
    {
        // Update メソッドはこのコードでは使用されていません
    }
}
