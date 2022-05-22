using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event MyEvent1;
   // public AK.Wwise.Event MyEvent2;
    //public AK.Wwise.Event MyEvent3;
    public AK.Wwise.State MyState1;
    public AK.Wwise.State MyState2;
    public void PlayResetSound()
    {
        MyEvent1.Post(gameObject);
    }

   /* public void PlayStepSound()
    {
        MyEvent2.Post(gameObject);
    }

    public void StopStepSound()
    {
        MyEvent3.Post(gameObject);
    } */

    public void PlayStepSound()
    {
        MyState1.SetValue();
    }

    public void StopStepSound()
    {
        MyState2.SetValue();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
