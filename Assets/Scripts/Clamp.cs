using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{
    public float min = -10f;
    public float max = 10f;
    // private float newMin = -5f;
    // private float newMax = 5f;
    static float t = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // float xPos = Mathf.Clamp(transform.position.x, newMin, newMax);
        // transform.position = new Vector3(xPos, 0, 0);

        transform.position = new Vector3(Mathf.Lerp(min, max, t), 0, 1);

        t += 0.5f * Time.deltaTime;

        if (t > 1.0f)
        {
            float temp = max;
            max = min;
            min = temp;
            t = 0.0f;
        }


    }
}
