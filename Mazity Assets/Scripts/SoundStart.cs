using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStart : MonoBehaviour
{
    private AudioSource SoundSt;
    // Start is called before the first frame update
    void Start()
    {
        SoundSt = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Start"))
        {
            

            SoundSt.Play();

            
        }
    }
}
