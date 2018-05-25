using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public float score;
    public int money;
    public int life;

    void Awake()
    {
        instance = this;
    }

    void Start () {

        score = 100;
        money = 500;
        life = 10;
        CanvasManager.instance.UpdateHUD();

    }
	
	void Update () {
		
	}
}
