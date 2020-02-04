using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType
{
    basic,
}
public class Bullet : MonoBehaviour
{
    public BulletType type;
    Vector3 hollowScale;
    private int timer=0;

    void Start()
    {
        
    }

    public void Builder(float ratio)
    {
        //ratioDamage = ratio;
        float hollowY = GameManager.manager.hollowPrefabio.transform.localScale.y;
        hollowScale = new Vector3(ratio, hollowY, ratio);

    }

    void Update()
    {
        timer++;
        if (timer==100)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Field")
        {
            GameObject hollow = Instantiate(GameManager.manager.hollowPrefabio);
            hollow.transform.localScale = hollowScale;
            hollow.transform.position = new Vector3(transform.position.x, other.transform.position.y, transform.position.z);
        }
        Destroy(gameObject);
    }
}
