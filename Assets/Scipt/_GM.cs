using UnityEngine;
//using UnityEditor;
using System.Collections;
using UnityEngine.UI;

public class _GM : MonoBehaviour {

	public Canvas showGameStartCanvas;
	public GameObject Gamestart;

	public Canvas showGameOverCanvas;

	public float GameTime;
	public Text GameTimeText;

	public Text popUpText;
	public Animator popUpAnimation;

	public Animator showHideBagAnimator;
	bool showHideBagFlag=false;

	public Canvas showHidePauseCanvas;
	bool showHidePauseFlag=false;

	void Start()
	{
		Time.timeScale = 1;

		showGameOverCanvas.enabled=false;

		showGameStartCanvas.enabled = true;

		showHidePauseCanvas.enabled = false;


	}

	void FixedUpdate()
	{
		timerGame ();
	}	
	public void restart()
	{
		Application.LoadLevel (Application.loadedLevel);
	}


	public void showHideBag()
	{
		showHideBagFlag = !showHideBagFlag;
		if (showHideBagFlag)
		showHideBagAnimator.SetBool ("showHideBag", true);
		else if (!showHideBagFlag)
			showHideBagAnimator.SetBool ("showHideBag", false);
	}

	public void showHidePause()
	{
		showHidePauseFlag = !showHidePauseFlag;
		if (showHidePauseFlag) 
		{
			showHidePauseCanvas.enabled = true;
			Time.timeScale=0;
		} 
		else if (!showHideBagFlag) 
		{
			showHidePauseCanvas.enabled = false;
			Time.timeScale=1;
		}
	}
	void timerGame()
	{
		GameTime -= Time.deltaTime;
		GameTimeText.text = "Time Remaining : " + (int)GameTime;
		if (GameTime <= 0) 
		{
			gameOver();
		}
	}
	public void gameOver()
	{
		GameTimeText.enabled = false;
		showGameOverCanvas.enabled=true;
	}
	public IEnumerator WaitTimePopUp(float time,string popText) 
	{
		popUpText.text = popText;
		popUpAnimation.SetBool ("EnablePopUp", true);
		popUpText.enabled = true;
		Debug.Log("Before Waiting");
		yield return new WaitForSeconds(time);
		popUpText.enabled = false;
		popUpAnimation.SetBool ("EnablePopUp", false);
		popUpText.text = " ";
		Debug.Log("After Waiting");
	}

}
