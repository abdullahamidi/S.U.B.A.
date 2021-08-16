using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSounder : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip stepOnGrass, stepOnWood;
    public static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

        stepOnGrass = Resources.Load<AudioClip>("Sounds/stepsound/stepongrass");
        stepOnWood = Resources.Load<AudioClip>("Sounds/stepsound/steponwood");
    }

    void Update()
    {

    }

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "stepongrass":
                audioSrc.clip = stepOnGrass;
                audioSrc.volume = 0.4f;
                if (!audioSrc.isPlaying)
                {
                    audioSrc.PlayOneShot(stepOnGrass);
                }
                break;
            case "steponwood":
                audioSrc.clip = stepOnWood;

                if (!audioSrc.isPlaying)
                {
                    audioSrc.PlayOneShot(stepOnWood);
                }
                break;
        }

    }
}
