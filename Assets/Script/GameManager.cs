using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> {

    protected override void Init()
    {
    }

    public float enemySpawnDelay = 2;
    public float bulletRateOfFire = 1;
    public float bulletSpeed = 5;
    public float turretRotateSpeed = 10;
    

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }
}
