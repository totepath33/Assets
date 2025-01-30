using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClockCount : MonoBehaviour
{
    [SerializeField]  Text textItems;
    [SerializeField] int Items;
    [SerializeField] int MaxItems;
    // Start is called before the first frame update
    void Start()
    {
        textItems.text = 0.ToString() +" / " + MaxItems.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Clock"))
        {

            Items++;

            textItems.text = Items.ToString() + " / " + MaxItems.ToString();
        }
    }
}
