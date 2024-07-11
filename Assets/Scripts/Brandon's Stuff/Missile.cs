using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float startSpeed;
    public float acceleration;
    public GameObject target;
    public GameObject explosion;
    float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Robber");
        speed = startSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetVector = (target.transform.position - transform.position).normalized;
        gameObject.transform.up = targetVector;
        speed += acceleration * Time.fixedDeltaTime;
        rb.AddForce(transform.up * speed, ForceMode.Acceleration);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Robber"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
