using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenerator : MonoBehaviour {


    public GameObject[] SpawnPositions;

    public GameObject CarToSpawn;

    public float MinTimer;
    public float MaxTimer;

    private float RealTime;

	// Use this for initialization
	void Start () {
        RealTime = CaLCuLaTeTiMe();

    }
	
	// Update is called once per frame
	void Update () {
        RealTime -= Time.deltaTime;
        if (RealTime <= 0)
        {
            SpAwN();
        }
	}

    float CaLCuLaTeTiMe()
    {
        return Random.Range(MinTimer, MaxTimer);
    }

    void SpAwN()
    {
        Instantiate(CarToSpawn, SpawnPositions[Random.Range(0, SpawnPositions.Length)].transform.position, SpawnPositions[Random.Range(0, SpawnPositions.Length)].transform.rotation);
        RealTime = CaLCuLaTeTiMe();
    }
}
