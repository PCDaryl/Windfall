using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Coin : MonoBehaviour
{
    public int spawnDomainMin,
               spawnDomainMax,
               spawnStartHeight;

    private int spawnStartDomain;

    public GameObject derpoCoin;

    public float spawnTime = 1.0f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnCoin", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void SpawnCoin()
    {
        spawnStartDomain = Random.Range(spawnDomainMin, spawnDomainMax);

        Instantiate(derpoCoin, new Vector3(spawnStartDomain, spawnStartHeight, -5.0f), Quaternion.identity);
    }
}
