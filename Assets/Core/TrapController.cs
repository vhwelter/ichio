using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour {

	public GameObject target;

	public int damage;

	public bool actived;

	void Start () {
		actived = false;
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collision2D)
	{
		if(!actived){
			target = collision2D.gameObject;
			target.GetComponent<EnemyController>().ApplyDamage(damage);
			actived = true;
			}
		}

	void OnTriggerExit2D(Collider2D collision2D)
	{
		actived = false;
	}

	void OnCollisionEnter2D(Collision2D collision2D)
	{
		Debug.Log("Teste 2");	
	}

	public void setDamage(int damage)
	{
		this.damage = damage;
	}
}
