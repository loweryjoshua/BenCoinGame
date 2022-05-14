using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBoxBehavior : MonoBehaviour
{

    [SerializeField]
    private bool isFalling;

    public float fallingSpeed;

    private bool beginFall;
    private float timerToFall;
    

    // Start is called before the first frame update
    void Start()
    {
        isFalling = false;
        beginFall = false;
        timerToFall = 3f;
        fallingSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(beginFall)
        {
            timerToFall -= Time.deltaTime;
            if (timerToFall < 0f)
            {
                beginFall = false;
                isFalling = true;
            }
        }
        if(isFalling)
        {
            this.transform.position = new Vector3(this.transform.position.x,
                                                  this.transform.position.y - (fallingSpeed * Time.deltaTime),
                                                  this.transform.position.z);
        }
        if(this.transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            beginFall = true;
        }
    }
}
