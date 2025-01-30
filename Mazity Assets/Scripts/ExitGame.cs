using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego..."); // Solo se ve en el editor
        Application.Quit(); // Cierra el juego
    }
    }
