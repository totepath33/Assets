using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundNature : MonoBehaviour
{
    private AudioSource SoundNat;
    // Start is called before the first frame update
    void Start()
    {
        SoundNat = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sound1"))
        {


            SoundNat.Play();


        }
    }
}
