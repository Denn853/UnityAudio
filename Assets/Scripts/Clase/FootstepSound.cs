using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footStepsOnGrass;
    public AudioClip[] footStepsOnWood;
    public AudioClip[] footStepsOnGravel;

    public string material;
    
    
    void PlayFootstepSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.volume = Random.Range(0.9f, 1.0f);
        aSource.pitch = Random.Range(0.8f, 1.0f);

        switch(material)
        {
            case "Wood":
                if (footStepsOnWood.Length > 0)
                    aSource.PlayOneShot(footStepsOnWood[Random.Range(0, footStepsOnWood.Length)]);
                break;

            case "Grass":
                if (footStepsOnGrass.Length > 0)
                    aSource.PlayOneShot(footStepsOnGrass[Random.Range(0, footStepsOnGrass.Length)]);
                break;

            case "Gravel":
                if (footStepsOnGravel.Length > 0)
                    aSource.PlayOneShot(footStepsOnGravel[Random.Range(0, footStepsOnGravel.Length)]);
                break;

            default:
                break;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Wood":
            case "Grass":
                //material = collision.gameObject.tag;
                break;

            default:
                material = "";
                break;

        }
    }
}
