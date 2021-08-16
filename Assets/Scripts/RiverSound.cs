using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverSound : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip flowingriver;
    public static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        flowingriver = Resources.Load<AudioClip>("Sounds/flowingriver");
    }

    void Update()
    {
        PlaySound("flowingriver");
    }

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "flowingriver":
                audioSrc.clip = flowingriver;
                audioSrc.volume = 0.4f;
                if (!audioSrc.isPlaying)
                {
                    audioSrc.PlayOneShot(flowingriver);
                }
                break;
        }
    }
}