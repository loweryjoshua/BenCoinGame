using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event MyEvent1;
    public AK.Wwise.Event MyTestEvent1;
    public AK.Wwise.State MyStateOn;
    public AK.Wwise.State MyStateOff;
    public void PlayResetSound()
    {
        MyEvent1.Post(gameObject);
    }

    public void PlayTestSound()
    {
        MyTestEvent1.Post(gameObject);
    }

     public void UnMuteStepSound()
    {
        MyStateOn.SetValue();
    }

    public void MuteStepSound()
    {
        MyStateOff.SetValue();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
