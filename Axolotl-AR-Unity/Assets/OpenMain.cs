using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMain : MonoBehaviour
{
 public void GoToMainScreenScene()
    {
        SceneManager.LoadScene(sceneName: "Main Screen");
    }
}
