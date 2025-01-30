using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTrap : MonoBehaviour
{
    [SerializeField] private GameManagerSO Gm;
    [SerializeField] private int IdZone;

    public void Activating()
    {
        Gm.ActivarAscensor(IdZone);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out PlaterMovement player))
        {
            Activating();
        }
    }
}
