using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Car : MonoBehaviour
{
    public float speed;
    public float thresholdSpeed;
    public float trapTime;
    bool isTrapped;
    float startTrapTime;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = Vector3.zero;
        rb.inertiaTensorRotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude<thresholdSpeed & !isTrapped)
        {
            isTrapped = true;
        }
        if (rb.velocity.magnitude > thresholdSpeed & isTrapped)
        {
            isTrapped = false;
        }
        if (!isTrapped)
        {
            startTrapTime = Time.time;
        }
        if(Time.time - startTrapTime > trapTime)
        {
            GameManager.main.OnWinCondition();
        }

    }
    private void FixedUpdate()
    {
        rb.AddForce(-transform.forward * speed, ForceMode.Acceleration);
    }
}
