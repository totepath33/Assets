using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameManagerSO Gm;
    [SerializeField] private int IdButton;
    [SerializeField] private Transform TargetPosition;
    [SerializeField] private float DoorVelocity;
     private AudioSource DoorSound;
    private bool OpenDoor = false;
    // Start is called before the first frame update
    void Start()
    {
        Gm.OnButtonPulsado += Abrir;
        DoorSound = GetComponent<AudioSource>();
    }

    private void Abrir( int IdManivelaActivada)
    {
        if (IdManivelaActivada == IdButton)
        {
            OpenDoor = true;
            
            if (!DoorSound.isPlaying)
            {
                DoorSound.Play();
            }
        }
        
    }



    // Update is called once per frame
    void Update()
    {
        if (OpenDoor)
        {
            transform.position = Vector3.MoveTowards(transform.position, TargetPosition.position, DoorVelocity * Time.deltaTime);

            if(Vector3.Distance(transform.position, TargetPosition.position) < 0.01f) 
            {
                OpenDoor = false;
                
                DoorSound.Stop();
            }
           

        }
    }
}
