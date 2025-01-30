using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSoundDown : MonoBehaviour
{
    [SerializeField] private GameObject Player; 
    private AudioSource[] PlayerSounds; // Array para guardas los dos sonidos que tiene el player y que se reproducen en loop


    // Start is called before the first frame update
    void Start()
    {
        PlayerSounds = Player.GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(PlayerSounds != null)
            {
                foreach(AudioSource Sounds in PlayerSounds)
                {
                    if (Sounds.isPlaying)
                    {
                        Sounds.Pause();
                    }
                }
            }
        }
    }
}
