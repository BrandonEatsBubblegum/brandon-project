using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpawner : MonoBehaviour
{
    public float interval = 5;
    public GameObject prefab;
    void Start()
    {
        InvokeRepeating("Spawn", 0, interval);
    }
    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
