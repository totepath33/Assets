using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClock : MonoBehaviour
{
    private AudioSource sClock;
    // Start is called before the first frame update
    void Start()
    {
        sClock = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            if (!sClock.isPlaying) 
            {
                sClock.Play();
            }


        }
    }
}
