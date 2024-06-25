using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetVector = (target.transform.position - transform.position).normalized;
        transform.LookAt(target.transform.position, Vector3.up);
    }
}
