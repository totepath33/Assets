using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaterMovement : MonoBehaviour
{
    [SerializeField] private float Velocity;
    [SerializeField] private float Gravity;
    [SerializeField] private Transform GravityCheck;
    [SerializeField] private float GroundDistance = 0.4f;
    [SerializeField] private LayerMask GroundMask;
    [SerializeField] private int DistanceDeteccionInteractuable;



    //[SerializeField] private float Jump;

    private CharacterController Controller;
    private Vector3 VerticalMove;
    bool Ongrounded;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Ongrounded = Physics.CheckSphere(GravityCheck.position, GroundDistance, GroundMask);

        if(Ongrounded && VerticalMove.y < 0)
        {
            VerticalMove.y = -2f;
        }

        float X = Input.GetAxisRaw("Horizontal");
        float Z = Input.GetAxisRaw("Vertical");

        //Vector3 MoveDirection = new Vector3(hInput, 0, vInput).normalized;
        //Controller.Move(MoveDirection * Velocity * Time.deltaTime);

        Vector3 MoveDirection = transform.right * X + transform.forward * Z;

        Controller.Move(MoveDirection * Velocity * Time.deltaTime);

        //if (Input.GetButtonDown("Jump") && Ongrounded)
        //{
        // VerticalMove.y = Mathf.Sqrt(Jump * -2f * Gravity);

        //}
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, DistanceDeteccionInteractuable))
            {
                if (hit.transform.TryGetComponent(out Manivela manivela))
                {
                    manivela.Interaction();
                }
            }
        }

        ApplyGravity();
    }

    private void ApplyGravity()
    {
        VerticalMove.y += Gravity * Time.deltaTime;
        Controller.Move(VerticalMove * Time.deltaTime);
    }
}
