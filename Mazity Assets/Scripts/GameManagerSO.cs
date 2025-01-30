using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameManager")]
public class GameManagerSO : ScriptableObject
{

    public event Action <int> OnButtonPulsado;

   

    public void ManivelaAcitvada(int idButton)
    {
        OnButtonPulsado?.Invoke(idButton);
    }
    public event Action<int> InZone;


    public void ActivarAscensor(int idZone)
    {
        InZone?.Invoke(idZone);
    }
    public event Action<int> Sublevel;
    public void ActivarBola(int idSubZone)
    {
        Sublevel?.Invoke(idSubZone);
    }
}
