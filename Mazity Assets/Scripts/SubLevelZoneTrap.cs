using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubLevelZoneTrap : MonoBehaviour
{
    [SerializeField] private GameManagerSO Gm;
    [SerializeField] private int IdSubZone;

    public void BallActivate()
    {
        Gm.ActivarBola(IdSubZone);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlaterMovement player))
        {
            BallActivate();
        }
    }
}
