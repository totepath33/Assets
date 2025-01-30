using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAdd : MonoBehaviour
{
    [SerializeField] float AddTime = 30f;
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
            TimerCentral Timer = FindObjectOfType<TimerCentral>(); 
            if (Timer != null)
            {
                Timer.AddTime(AddTime);
               
            }
            FeedBackUI uiFeedback = FindObjectOfType<FeedBackUI>();
            if (uiFeedback != null)
            {
                uiFeedback.ShowTimeGained();
            }
            sClock.Play();
           

            Destroy(gameObject, sClock.clip.length); // elimina el objeto tras recogerlo
        }
    }

}
