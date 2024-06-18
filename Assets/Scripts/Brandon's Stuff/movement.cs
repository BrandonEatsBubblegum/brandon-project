using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + -transform.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + -transform.forward;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position = transform.position + transform.up;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = transform.position + -transform.up;
        }

    }
}
