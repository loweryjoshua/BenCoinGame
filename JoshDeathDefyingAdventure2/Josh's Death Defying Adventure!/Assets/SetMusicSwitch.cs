using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMusicSwitch : MonoBehaviour
{
    public AK.Wwise.Switch OnCollideEnterSwitch;
    public AK.Wwise.Switch OnCollideExitSwitch;

    public AK.Wwise.Event TestEvent;
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //  OnCollideEnterSwitch.SetValue(gameObject);
            TestEvent.Post(gameObject);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
          //  OnCollideExitSwitch.SetValue(gameObject);
        }
    } */

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stairs"))
        {
            OnCollideEnterSwitch.SetValue(this.gameObject);
            TestEvent.Post(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Stairs"))
        {
            OnCollideExitSwitch.SetValue(this.gameObject);
            TestEvent.Post(gameObject);
        }
    }

}
