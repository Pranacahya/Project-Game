using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	//public static trigger instance;

	public _GM GM;
	
	void Start () 
	{

	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		GM.gameOver ();
	}

}
