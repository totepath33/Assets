using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStart : MonoBehaviour
{
    [SerializeField] TimerCentral TimerManager;
    //private AudioSource SoundStart;

    // Start is called before the first frame update
    void Start()
    {
        //SoundStart = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TimerManager.StartTimer();

            //SoundStart.Play();

            Destroy(gameObject); // Elimina el objeto tras recogerlo
        }
    }
}
