using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health = 2;
    public float delay = 2;
    public GameObject enemyObject;
    public GameObject destroyedParticle;

    private GameObject playerObject;
    private float timer = 0;

	// Use this for initialization
	void Start () {
        playerObject = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        this.transform.Translate(Vector3.MoveTowards(this.transform.position, playerObject.transform.position, 0.1f) * -0.005f);
        if (health <= 0)
        {
            Debug.Log(timer);
            timer += Time.deltaTime;
            DestroySequence();
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "Player")
        {
            Debug.Log("Game Over");
            Destroy(this.gameObject);
        }
        else if (coll.tag == "Bullet")
        {
            health--;
            Destroy(coll.gameObject);
        }
    }

    void DestroySequence()
    {
        enemyObject.SetActive(false);
        destroyedParticle.SetActive(true);
        this.GetComponent<BoxCollider>().enabled = false;
        if (timer >= delay)
        {
            Destroy(this.gameObject);
        }
    }
}
