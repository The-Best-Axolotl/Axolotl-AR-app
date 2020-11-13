using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Switching : MonoBehaviour
{
    public void GotoMainScreen()
    {
        SceneManager.LoadScene("main screen");
    }

    public void GotoHomeScreen()
    {
        SceneManager.LoadScene("home screen");
    }
    public void GotoVideo()
    {
        SceneManager.LoadScene("tutorial screen");
    }
    public void GotoSettings()
    {
        SceneManager.LoadScene("settings screen");
    }
    public void GotoEdit()
    {
        SceneManager.LoadScene("editing screen");
    }
    public void GotoWarning()
    {
        SceneManager.LoadScene("warning screen");
    }
}