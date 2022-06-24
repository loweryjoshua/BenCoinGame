using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public AK.Wwise.Event MyEvent1;
    public AK.Wwise.Event MyEvent2;

 
    public void PlayGame()
    {
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {
        MyEvent1.Post(gameObject);
        MyEvent2.Post(gameObject);

        yield return new WaitForSeconds(2);
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
        // save any game data here
        #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                 Application.Quit();
        #endif
    }
}
