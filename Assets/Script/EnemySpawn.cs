using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemyObject;

    private GameObject[] spawnPos;
    private float spawnDelay = 0f;
    private int randomPos;

    // Use this for initialization
    void Start()
    {
        spawnPos = GameObject.FindGameObjectsWithTag("Spawn");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        spawnDelay += Time.deltaTime;
        randomPos = Random.Range(0, spawnPos.Length);
        if (spawnDelay >= GameManager.Instance.enemySpawnDelay)
        {
            Instantiate(enemyObject, spawnPos[randomPos].transform.position, Quaternion.identity);
            spawnDelay = 0;
        }
    }
}
