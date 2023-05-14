using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudio : MonoBehaviour
{
    public AudioClip[] sound;

    public string chance;


    void PlayRandomSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.volume = Random.Range(0.9f, 1.0f);
        aSource.pitch = Random.Range(0.8f, 1.0f);
        
        aSource.PlayOneShot(sound[Random.Range(0, sound.Length)]);
    }
}