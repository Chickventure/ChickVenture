using UnityEngine;

public class CutSceneController : MonoBehaviour
{
    public AudioSource musicAudioSource;

    public void StartCutScene()
    {
        if (musicAudioSource != null)
        {
            musicAudioSource.Stop();
        }

    }

    public void EndCutScene()
    {
        if (musicAudioSource != null)
        {
            musicAudioSource.Play();
        }

    }
}
