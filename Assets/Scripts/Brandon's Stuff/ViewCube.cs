using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ViewCube : MonoBehaviour
{
    public LayerMask layerMask;
    List<Collider> colliders = new List<Collider>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if((layerMask.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            colliders.Add(other);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((layerMask.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            colliders.Remove(other);
        }
    }
    public bool CanSeeSomething()
    {
        return colliders.Count > 0;
    }
}
