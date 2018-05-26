using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collision2D)
	{
		Debug.Log("Teste 1");
		Destroy(collision2D.gameObject);
	}

	void OnCollisionEnter2D(Collision2D collision2D)
	{
		Debug.Log("Teste 2");	
	}
}
