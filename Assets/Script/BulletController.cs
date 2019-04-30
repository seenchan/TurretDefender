using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public GameObject bulletSprite;
    public GameObject gunBarrel;

    private float bulletDelay = 0f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletDelay += Time.deltaTime;
        if (bulletDelay >= GameManager.Instance.bulletRateOfFire)
        {
            Instantiate(bulletSprite, gunBarrel.transform.position, Quaternion.identity);
            bulletDelay = 0;
        }
    }
}
