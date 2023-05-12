using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnvironmentChange : MonoBehaviour
{
    public AudioMixerSnapshot indoor;
    public AudioMixerSnapshot outdoor;

    public float transitionTime = 0.25f;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Indoor")
        {
            indoor.TransitionTo(transitionTime);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        outdoor.TransitionTo(transitionTime);
    }
}
