using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetPowerCollectable : MonoBehaviour
{
    public int amount = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponentInParent<NetPowerup>().GetPowerup(amount);
            Destroy(gameObject);
        }
    }
}
