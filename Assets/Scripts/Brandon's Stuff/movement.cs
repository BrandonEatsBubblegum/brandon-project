using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject projectile;
    public float boostSpeed;
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rb.AddForce(movement * speed, ForceMode.Acceleration);

        /*float boostHorizontal = Input.GetAxis("Horizontal Boost");
        float boostVertical = Input.GetAxis("Vertical Boost");
        Vector3 boostMovement = new Vector3(boostHorizontal, 0, boostVertical);*/
        if(Input.GetButton("Boost"))
        {
            rb.AddForce(movement * boostSpeed, ForceMode.Acceleration);
            GameObject go = Instantiate(projectile, transform.position, transform.rotation);
            go.GetComponentInChildren<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
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
