using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]

public class SoundManager : Singleton<SoundManager>
{

    [HideInInspector]
    public float _destinationVolume = 1.0f;

    public AudioClip _cartouch;
    public AudioClip _explosion;

    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 1.0f;
    }

    void Update()
    {

       // _audioSource.volume = Mathf.Lerp(_audioSource.volume, _destinationVolume, Time.deltaTime);
    }

    public void PlayCartouchSound()
    {
        _audioSource.PlayOneShot(_cartouch);
    }

    public void PlayExplosionSound()
    {
        _audioSource.PlayOneShot(_explosion);
    }

}