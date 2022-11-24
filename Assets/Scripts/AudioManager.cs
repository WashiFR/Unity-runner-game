using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de AudioManager dans la scène");
            return;
        }

        instance = this;
    }

    void Start()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
