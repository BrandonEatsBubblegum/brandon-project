using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ViewCube : MonoBehaviour
{
    public LayerMask layerMask;
    Collider[] colliders = new Collider[0];
    public Collider viewCol;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Collider[] cols = Physics.OverlapBox(viewCol.transform.position, viewCol.transform.lossyScale, viewCol.transform.rotation, layerMask);
        Debug.Log(cols.Length);
        colliders = cols;
    }
    public bool CanSeeSomething()
    {
        return colliders.Length > 0;
    }
}
