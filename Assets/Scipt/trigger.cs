using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
	public static trigger instance;
	public bool triggered=false;
	void Start () 
	{
		instance = this;
	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		triggered=true;
	}
	void OnTriggerExit2D(Collider2D other) 
	{
		triggered=false;
	}
}
