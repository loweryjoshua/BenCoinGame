using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasBehavior : MonoBehaviour
{
    GameManager gm;

    private TMP_Text LifeText;
    private TMP_Text TimeText;
    private TMP_Text CoinText;
    private TMP_Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        LifeText = this.transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
        TimeText = this.transform.GetChild(1).gameObject.GetComponent<TMP_Text>();
        CoinText = this.transform.GetChild(2).gameObject.GetComponent<TMP_Text>();
        ScoreText = this.transform.GetChild(3).gameObject.GetComponent<TMP_Text>();
        this.transform.GetChild(3).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LifeText.text = "Lives: " + gm.LivesRemaining;
        TimeText.text = "" + gm.SecondsSpentInGame;
        CoinText.text = "Coins: " + (gm.coinNumOriginally - gm.NumberOfCoinsLeft);

        if(gm.PlayerWinGame)
        {
            this.transform.GetChild(3).gameObject.SetActive(true);
            ScoreText.text = "Score: " + gm.TotalScore;
        }
    }
}
