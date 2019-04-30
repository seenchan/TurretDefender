using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    private GameObject gunPointer;
    private float lifeTime = 0;

	// Use this for initialization
	void Start () {
        gunPointer = GameObject.Find("GunPointer");
        this.gameObject.GetComponent<Rigidbody>().AddForce((gunPointer.transform.position - this.transform.position)*GameManager.Instance.bulletSpeed);
    }

    // Update is called once per frame
    void FixedUpdate () {
        lifeTime += Time.deltaTime;
        if(lifeTime >= 5)
        {
            Destroy(this.gameObject);
        }
	}
}
