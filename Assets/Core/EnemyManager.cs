using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject enemyPrefab;

	void Start () {

        Invoke("CreateEnemy", 1);

	}

    public void CreateEnemy()
    {
        Transform start = WaypointManager.instance.GetStart().transform;
        Instantiate(
            enemyPrefab,
            start.position,
            Quaternion.identity
        );
        Invoke("CreateEnemy", 2);   
    }
}
