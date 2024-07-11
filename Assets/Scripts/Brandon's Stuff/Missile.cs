using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;
    public GameObject target;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Robber");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetVector = (target.transform.position - transform.position).normalized;
        gameObject.transform.up = targetVector;

        rb.AddForce(transform.up * speed, ForceMode.Acceleration);
    }
}
