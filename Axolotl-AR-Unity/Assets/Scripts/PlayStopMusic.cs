using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopMusic : MonoBehaviour
{
    public void PlayMusic()
    {
        GameObject.Find("Music").GetComponent<MusicClass>().PlayMusic();
    }
    public void StopMusic()
    {
        GameObject.Find("Music").GetComponent<MusicClass>().StopMusic();
    }
}
