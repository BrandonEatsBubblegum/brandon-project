using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSucker : MonoBehaviour
{
    public string tag;
    public float radius;
    public float force;
    private void FixedUpdate()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider col in cols)
        {
            if(!col.CompareTag(tag))
            {
                continue;
            }
            Rigidbody rb = col.GetComponent<Rigidbody>();
            if(rb != null)
            {
                Vector3 dir = (col.transform.position - transform.position).normalized;
                rb.AddForce(-dir * force, ForceMode.Acceleration);
            }
        }
    }
}
