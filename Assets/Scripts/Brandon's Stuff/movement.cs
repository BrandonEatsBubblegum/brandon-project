using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rb.AddForce(movement * speed, ForceMode.Acceleration);
        /*        if (Input.GetKey(KeyCode.D))
                {
                    transform.position = transform.position + transform.right * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.position = transform.position + -transform.right * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position = transform.position + transform.forward * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    transform.position = transform.position + -transform.forward * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.E))
                {
                    transform.position = transform.position + transform.up * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.Q))
                {
                    transform.position = transform.position + -transform.up * speed * Time.deltaTime;
                }*/

    }
}
