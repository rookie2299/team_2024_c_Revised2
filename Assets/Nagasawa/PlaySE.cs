using UnityEngine;

public class PlaySE : MonoBehaviour
{
    public AudioSource seSource; // SE用のAudioSource
    public AudioClip seClip;     // 再生するSEのAudioClip

    // SEを再生
    public void PlaySoundEffect()
    {
        seSource.PlayOneShot(seClip);
    }
}
