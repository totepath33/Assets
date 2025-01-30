using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Manivela : MonoBehaviour
{
    [SerializeField] private GameManagerSO Gm;
    [SerializeField] private int IdButton;
    [SerializeField] private float RotationVelocity = 90f;
    //[SerializeField] private Transform Destination;
    private bool Rotating;


    public void Interaction()
    {
        if (!Rotating)
        {
            Rotating = true;
            Gm.ManivelaAcitvada(IdButton);
        }
    }

    private void Update()
    {
       if (Rotating)
        {
            transform.Rotate(Vector3.up, RotationVelocity * Time.deltaTime);

            if(transform.rotation.eulerAngles.y >= 90f)
            {
                transform.rotation = Quaternion.Euler(0, 90f, 0);
                Rotating = false;
            }
        }
    }

}
