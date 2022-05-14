using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int NumberOfCoinsLeft;
    public float SecondsSpentInGame;

    public bool PlayerWinGame;
    public int LivesRemaining;
    public int TotalScore;

    private float endGameStep;
    public int coinNumOriginally;
    private bool firstUpdate;

    // Start is called before the first frame update
    void Awake()
    {
        NumberOfCoinsLeft = 0;
        SecondsSpentInGame = 0f;
        LivesRemaining = 3;
        TotalScore = 0;
        endGameStep = 5f;
        firstUpdate = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(firstUpdate)
        {
            firstUpdate = false;
            coinNumOriginally = NumberOfCoinsLeft;
        }
        // while the player has not made it to the last platform!
        if (!PlayerWinGame)
        {
            SecondsSpentInGame += Time.deltaTime;
        }
        else
        {
            endGameStep -= Time.deltaTime;
            TotalScore = (int)((coinNumOriginally - NumberOfCoinsLeft) * (60f / SecondsSpentInGame) * 100f * LivesRemaining);
        }

        if (endGameStep < 0f)
        {
            Debug.Log(TotalScore + " is the Player's Final Score");
            Debug.Log("Ending Game and going to credits!");
            SceneManager.LoadScene("EndingCredits");
        }

    }
}
