using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetPowerup : MonoBehaviour
{
    public int netsLeft = 3;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.main.UpdateMissileText("Missiles: " + netsLeft);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J) && netsLeft > 0)
        {
            SpawnNet();
        }
        if (Input.GetKey(KeyCode.K) && netsLeft > 0)
        {
            SpawnNet();
        }
    }
    void SpawnNet()
    {
        netsLeft -= 1;
        Instantiate(projectile, transform.position, Quaternion.identity);
        GameManager.main.UpdateMissileText("Missiles: " + netsLeft);
    }
    public void GetPowerup()
    {
        netsLeft += 1;
        GameManager.main.UpdateMissileText("Missiles: " + netsLeft);
    }
}
