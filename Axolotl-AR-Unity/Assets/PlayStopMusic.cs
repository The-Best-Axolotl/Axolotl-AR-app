using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopMusic : MonoBehaviour
{
    public void PlayMusic()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }
    public void StopMusic()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
    }
}
