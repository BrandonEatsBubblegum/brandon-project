using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public float despawnTime;
    private void Start()
    {
        Invoke("Kill", despawnTime);
    }
    void Kill()
    {
        Destroy(gameObject);
    }
}
