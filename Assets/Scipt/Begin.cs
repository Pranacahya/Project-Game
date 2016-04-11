	using UnityEngine;
using System.Collections;

public class Begin : MonoBehaviour {

	private float waitTime=3;
	void Start () 
	{
		Time.timeScale=1;
	}

	void Update () 
	{
		waitTime -= Time.deltaTime;
		if (waitTime <= 0) {
			loadLevel ();
			Application.LoadLevel (Application.loadedLevel + 1);
		}
	}
	public IEnumerator loadLevel()
	{
		float fadeTime = GameObject.Find ("Fader").GetComponent<fade> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
	}
}
