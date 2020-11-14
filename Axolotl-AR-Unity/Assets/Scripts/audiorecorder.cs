using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiorecorder : MonoBehaviour
{
    AudioClip reco;
    // Use this for initialization
    public void onClick()
    {
        AudioSource aud;
        aud = GetComponent<AudioSource>();
        foreach (string device in Microphone.devices)
        {
            Debug.Log(device);
        }
        reco = Microphone.Start("Built-in Microphone", true, 10, 44100);
        aud.clip = reco;

        aud.Play();
    }

}