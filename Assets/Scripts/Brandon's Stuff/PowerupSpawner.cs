using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject powerup;
    public float force = 100f;
    public float cooldownLength = 1;
    bool canSpawn = true;
    private void OnCollisionEnter(Collision collision)
    {
        if(canSpawn && collision.collider.CompareTag("Player"))
        {
            canSpawn = false;
            StartCoroutine(Wait());
            GameObject instance = Instantiate(powerup, transform.position + Vector3.up * 5, Quaternion.identity);
            instance.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * force, ForceMode.VelocityChange);
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(cooldownLength);
        canSpawn = true;
    }
}
