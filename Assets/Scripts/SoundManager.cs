using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip burningWood, flowingriver, planting;
    public static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();


        burningWood = Resources.Load<AudioClip>("Sounds/burningwood");
        flowingriver = Resources.Load<AudioClip>("Sounds/flowingriver");
        planting = Resources.Load<AudioClip>("Sounds/planting");
    }

    void Update()
    {

    }

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "burningwood":
                audioSrc.clip = burningWood;

                if (!audioSrc.isPlaying)
                {
                    audioSrc.PlayOneShot(burningWood);
                }
                break;

            case "flowingriver":
                audioSrc.clip = flowingriver;

                if (!audioSrc.isPlaying)
                {
                    audioSrc.PlayOneShot(flowingriver);
                }
                break;

            case "planting":
                audioSrc.clip = planting;

                if (!audioSrc.isPlaying)
                {
                    audioSrc.PlayOneShot(planting);
                }
                break;
        }

    }
}
