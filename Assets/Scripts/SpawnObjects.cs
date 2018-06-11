using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public GameObject Foodprefab;

	public Vector3 center;
	public Vector3 size;
    public float time;
    public float resetTime;
    public float spawnTime;

	// Use this for initialization
	void Start () {
        if (time < 60)
        {
            spawnTime = Random.Range(2, 5);
        }
        else if (time > 60 && time < 180)
        {
            spawnTime = Random.Range(1, 4);
        }
        else if (time > 180) {
            spawnTime = Random.Range(0, 2);
        }
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        resetTime += Time.deltaTime;

        if (resetTime > spawnTime) {
            SpawnFood();
            resetTime = 0;

            if (time < 60)
            {
                spawnTime = Random.Range(3, 8);
            }
            else if (time > 60 && time < 180)
            {
                spawnTime = Random.Range(3, 7);
            }
            else if (time > 180)
            {
                spawnTime = Random.Range(2, 5);
            }
        }

    }

	public void SpawnFood()
	{
		Vector3 pos = center + new Vector3 (Random.Range (-size.x / 2, size.x / 2), Random.Range (-size.y / 2, size.y / 2), Random.Range (-size.z / 2, size.z / 2));



		Instantiate (Foodprefab, pos, Quaternion.identity);
	}

	void OnDrawGizmosSelected() {
	
		Gizmos.color = new Color (1, 0, 0, 0.5f);
		Gizmos.DrawCube (center, size);
	}
}
