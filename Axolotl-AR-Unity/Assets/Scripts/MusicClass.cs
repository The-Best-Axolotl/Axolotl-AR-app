using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        //DontDestroyOnLoad(transform.gameObject);

        int numMusicPlayers = FindObjectsOfType<MusicClass>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(transform.gameObject);
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.UnPause();
    }

    public void StopMusic()
    {
        _audioSource.Pause();
    }
}
