using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    private GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        GameManager.GetComponent<GameManager>().NumberOfCoinsLeft += 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, 100 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has collected a coin!");
            GameManager.GetComponent<GameManager>().NumberOfCoinsLeft -= 1;
            Destroy(this.gameObject);
        }
    }
}
