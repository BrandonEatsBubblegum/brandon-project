using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetPowerup : MonoBehaviour
{
    public GameObject projectile;
    bool canUse = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        canUse = true;
        if(Input.GetKeyDown(KeyCode.J) && canUse)
        {
            canUse = false;
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
    public void GetPowerup()
    {
        canUse = true;
    }
}
