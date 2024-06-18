using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingTarget : MonoBehaviour
{
    private float randX;
    private float randY;
    private float randZ;

    // Start is called before the first frame update
    void Start()
    {
        // EXERCISE 2.8.2: Write code below.

        transform.position = new Vector3(randX, randY, randZ);

    }

}
