using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        //sets camera distance between ball and camera
        distance = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //continuously follow the ball at a constant distance
        this.transform.position = player.transform.position + distance;
    }
}
