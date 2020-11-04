﻿using System.Collections;
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
}