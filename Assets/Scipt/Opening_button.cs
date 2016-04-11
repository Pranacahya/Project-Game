using UnityEngine;
using System.Collections;

public class Opening_button : MonoBehaviour {
	
	void Start () 
	{
		Time.timeScale=1;
	}

	public IEnumerator loadLevel()
	{
		float fadeTime = GameObject.Find ("Fader").GetComponent<fade> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
	}
	public void clickPlay()
	{
		loadLevel ();
		Application.LoadLevel (Application.loadedLevel+1);
	}
}
