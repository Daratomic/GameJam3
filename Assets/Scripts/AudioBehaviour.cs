using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBehaviour : MonoBehaviour
{
    // refer to audio source component
    public AudioSource audioSource;

    void Start()
    {
        // check if assigned
        if (audioSource != null)
        {
            // play
            audioSource.Play();

            // keeps music going when loading to new scene
            DontDestroyOnLoad(gameObject);
        }
    }
}
