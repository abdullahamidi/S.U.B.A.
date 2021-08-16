using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip mainSound;
    public static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        mainSound = Resources.Load<AudioClip>("Sounds/menuMuzik");
    }

    void Update()
    {
        PlaySound();
    }

    public static void PlaySound()
    {


        audioSrc.clip = mainSound;
        audioSrc.volume = 0.1f;
        if (!audioSrc.isPlaying)
        {
            audioSrc.PlayOneShot(mainSound);
        }
    }
}