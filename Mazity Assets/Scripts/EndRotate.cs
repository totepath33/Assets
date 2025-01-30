using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRotate : MonoBehaviour
{
    [SerializeField] private float vERotate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * vERotate * Time.deltaTime, Space.World);
    }

}
