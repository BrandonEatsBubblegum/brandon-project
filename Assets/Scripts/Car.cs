using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Car : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float thresholdSpeed;
    public float explosionForce;
    public float explosionRange;
    public float explosionTime;
    public float trapTime;
    public float explosionsLeft = 3;
    public AudioClip explosionSound;
    public ViewCube viewCube;
    bool isTrapped;
    float startTrapTime;
    bool isTurningRight;
    AudioSource audioSource;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = Vector3.zero;
        rb.inertiaTensorRotation = Quaternion.identity;
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(Flip());
    }
    bool isFlipping = true;
    IEnumerator Flip()
    {
        while(isFlipping)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            isTurningRight = !isTurningRight;
        }
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
        if (Time.time - startTrapTime > trapTime)
        {
            GameManager.main.OnWinCondition();
        }
        if (Time.time - startTrapTime > explosionTime & explosionsLeft > 0)
        {
            DoExplosion();

            audioSource.clip = explosionSound;
            audioSource.Play();

            explosionsLeft -= 1;
            startTrapTime = Time.time;
            isTrapped = false;
        }

    }
    private void FixedUpdate()
    {
        rb.AddForce(-transform.forward * speed, ForceMode.Acceleration);
        if (viewCube.CanSeeSomething())
        {
            int mult = isTurningRight ? 1 : -1;
            rb.AddTorque(transform.up * turnSpeed * mult, ForceMode.Acceleration);
        }
    }
    void DoExplosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRange);
        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRange, explosionForce/10, ForceMode.VelocityChange);
            }
        }
    }
}
