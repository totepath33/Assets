using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour
{
    [SerializeField] GameManagerSO Gm;
    [SerializeField] private int IdTecho;
    [SerializeField] private float VelocityDown;
    private AudioSource SoundDown;
    [SerializeField] private float StopY;
    private bool Down;
    // Start is called before the first frame update
    

    private void OnEnable()
    {
        Gm.InZone += Bajar;
        SoundDown = GetComponent<AudioSource>();
    }

    private void Bajar(int IdZone)  
    {
        if(this.IdTecho == IdZone)
        {
            Down = true;
            SoundDown.Play();
        }
    }

    private void Update()
    {
        if(Down)
        {
            transform.Translate(Vector3.down * VelocityDown * Time.deltaTime, Space.World);

            if(transform.position.y <= StopY)
            {
                Down = false;
                SoundDown.Stop();
            }
            
        }
    }
}
