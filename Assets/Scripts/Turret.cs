using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bullet, cannonHead;
    int shotTimer = 0, shotLapse=100;
    
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        shotTimer++;
        if (shotTimer>=shotLapse)
        {
            Shot();
            shotTimer = 0;
            shotLapse = Random.Range(10, 300);
        }
    }

    public void Shot()
    {
        GameObject drop = Instantiate(bullet);
        drop.transform.position = cannonHead.transform.GetChild(0).transform.position;
        drop.transform.eulerAngles = cannonHead.transform.eulerAngles;
        drop.AddComponent<Bullet>().Builder(bullet.transform.localScale.magnitude);
        drop.GetComponent<Rigidbody>().AddForce(drop.transform.forward * 100);
        
    }
}
