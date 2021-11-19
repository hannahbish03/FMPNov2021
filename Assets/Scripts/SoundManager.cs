using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   
    private AudioSource[] mySounds;

    public AudioSource coin;
    public AudioSource run;
    private void Start()
    {
        mySounds = GetComponents<AudioSource>();

       // coin = mySounds[1];
       // run = mySounds[0];
    }


    public void Playcoin()
    {
        coin.Play();
    }

    public void Playrun()
    {
        run.Play();
    }


}
