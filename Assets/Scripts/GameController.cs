using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject hazard;
	public Vector3 spawnValues;

	void Start() {
		SpawnWaves ();
	}
	void SpawnWaves(){
		Vector3 spawnPos = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRot = Quaternion.identity;
		Instantiate (hazard, spawnPos, spawnRot);
	}
}
