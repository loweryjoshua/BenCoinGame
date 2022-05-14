using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Adventure");
    }

    public void Credits()
    {
        SceneManager.LoadScene("EndingCredits");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void EndApplication()
    {
        Application.Quit(0);
    }
}
