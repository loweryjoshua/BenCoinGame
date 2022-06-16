using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseMenuEvents : MonoBehaviour
{
    public AK.Wwise.Event MyEvent1;

    public void PlayGameStartSound()
    {
        MyEvent1.Post(gameObject);
    }
}
