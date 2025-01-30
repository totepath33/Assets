using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEnd : MonoBehaviour
{

    [SerializeField] private GameObject Player;
    [SerializeField] private Transform TeleportToEnd;
    [SerializeField] private CharacterController PlayerController;
    private AudioSource SountTeleport;

    // Start is called before the first frame update
    void Start()
    {
        SountTeleport = GetComponent<AudioSource>();
        PlayerController = Player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (PlayerController != null)
            {
                PlayerController.enabled = false;
                Player.transform.position = TeleportToEnd.position;
                PlayerController.enabled = true;
                SountTeleport.Play(); 
            }
            else
            {
                Player.transform.position = TeleportToEnd.position;
            }
        }
    }
}
