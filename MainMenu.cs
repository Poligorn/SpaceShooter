using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneName;

    public void OnClickStart()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickExit()
    {
        Application.Quit();
        print("Exit was clicked");
    }
}
