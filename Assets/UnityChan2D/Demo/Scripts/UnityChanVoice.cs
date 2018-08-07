using UnityEngine;

[RequireComponent(typeof(UnityChan2DController), typeof(AudioSource))]
public class UnityChanVoice : MonoBehaviour
{
    [SerializeField]
    private AudioClip damageVoice;

    [SerializeField]
    private AudioClip[] jumpVoices;

    [SerializeField]
    private AudioClip[] clearVoice;

    [SerializeField]
    private AudioClip timeOverVoice;

    [SerializeField]
    private AudioClip GameOverVoice;

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnDamage()
    {
        PlayVoice(damageVoice);
    }

    void Jump()
    {
        int i = Random.Range(0, jumpVoices.Length);
        PlayVoice(jumpVoices[i]);
    }

    void Clear()
    {
        int i = Random.Range(0, clearVoice.Length);
        PlayVoice(clearVoice[i]);
    }

    void TimeOver()
    {
        PlayVoice(timeOverVoice);
    }

    void GameOver()
    {
        PlayVoice(GameOverVoice);
    }

    void PlayVoice(AudioClip voice)
    {
        audioSource.Stop();
        audioSource.PlayOneShot(voice);
    }
}