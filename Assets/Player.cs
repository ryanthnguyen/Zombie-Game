using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    public Transform playerSpawnPoints;
    public bool Respawn = false;
    private Transform[] SpawnPoints;
    private bool lastToggle = false;
	void Start()
	{
        SpawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(SpawnPoints.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != Respawn)
        {
            RespawnPoints();
            Respawn = false;
        } else
        {
            lastToggle = Respawn;
        }
	}

    private void RespawnPoints()
    {
        int i = Random.Range(1, SpawnPoints.Length);
        transform.position = SpawnPoints[i].transform.position;
    }
}

