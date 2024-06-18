using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mystufflwillworkon : MonoBehaviour
{
    public GameObject cloneObject;
    public int numOfCubes = 1;

    // Start is called before the first frame update
    void Start()
    {
        print("inf hp");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            Debug.Log("hi");
            print("joshua is superior");
            for(int i = 0; i < numOfCubes; i++)
            {
                Instantiate(cloneObject, transform.position, transform.rotation);
            }
        }
    }
}
