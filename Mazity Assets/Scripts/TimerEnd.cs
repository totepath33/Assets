using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerEnd : MonoBehaviour
{
    [SerializeField] TimerCentral TimerManagerEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            TimerManagerEnd.StopTimer();

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;  // cursor visible


            SceneManager.LoadScene("Victory");  // Carga la pantalla de victoria 
            

            Destroy(gameObject); // Elimina el objeto tras recogerlo

        }
    }
}
