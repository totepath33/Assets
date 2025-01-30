using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    private Light ControlLinterna;
    // Start is called before the first frame update
    void Start()
    {
        ControlLinterna = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            ControlLinterna.enabled = !ControlLinterna.enabled;
    }
}
