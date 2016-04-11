using UnityEngine;
//using UnityEditor;
using System.Collections;
using UnityEngine.UI;

public class QuestionControl : MonoBehaviour {

	public _GM GM;

	public float tempGameTimeCurrent;
	public float tempGameTimeTotal;

	public Text popUpText;
	public Animator popUpAnimation;

	public Canvas QuestionCanvas;

	public Text QuestionText;
	public Text Atext;
	public Text Btext;
	public Text Ctext;
	public Text Dtext;

	public char trueChoose;

	bool finish=false;

	public Canvas FinishCanvas;
	public Animator StarAnim;

	void Start () 
	{
		tempGameTimeTotal = GM.GameTime;
		QuestionCanvas.enabled = false;
		popUpText.enabled = false;
		FinishCanvas.enabled = false;
	}

	void Update () 
	{
	
	}
	public void YourAnswer(char chooseAnswer)
	{
		if (trueChoose == chooseAnswer)
			trueAnswer();
		else
			wrongAnswer ();
	}
	public void A()
	{
		YourAnswer ('A');
	}
	public void B()
	{
		YourAnswer ('B');
	}
	public void C()
	{
		YourAnswer ('C');
	}
	public void D()
	{
		YourAnswer ('D');
	}

	public void wrongAnswer()
	{
		GM.GameTime -= 10;
		StartCoroutine(GM.WaitTimePopUp(1,"Wrong Answer"));
	}
	public void trueAnswer() 
	{
		QuestionCanvas.enabled = false;
		if (finish) 
		{
			FinishCanvas.enabled = true;
			Time.timeScale=0;
			scoring();
		}
	}
	public void scoring()
	{
		tempGameTimeCurrent = GM.GameTime;
		GM.GameTimeText.enabled = false;
		Time.timeScale = 1;
		if ((tempGameTimeCurrent / tempGameTimeTotal) >= (0.5)) 
		{
			//3 Star
			print ("3Star");
		} 
		else if ((tempGameTimeCurrent / tempGameTimeTotal) >= (0.3333)) 
		{
			print ("2Star");
			//2 Star
		} 
		else if ((tempGameTimeCurrent / tempGameTimeTotal) >= (0.111)) 
		{
			//1 Star
			print ("1Star");
		} 
		else 
		{
			print ("0Star");
			//No Star
		}
		StarAnim.SetFloat ("score", tempGameTimeCurrent / tempGameTimeTotal);
	}
	public void QuestionStage1()
	{
		int choose = Random.Range (1, 3);
		if (choose == 1) 
		{
			QuestionText.text = "Berapakah hasil dari 1 / 2 + 1 / 4 ?";
			Atext.text = "A. 1 / 6";
			Btext.text = "B. 1 / 8";
			Ctext.text = "C. 3 / 4";
			Dtext.text = "D. 2 / 6";
			trueChoose = 'C';
		}
		else 
		{
			QuestionText.text = "Berapakah hasil dari 1 / 2 - 1 / 4 ?";
			Atext.text = "A. 1 / 6";
			Btext.text = "B. 1 / 4";
			Ctext.text = "C. 3 / 4";
			Dtext.text = "D. 2 / 6";
			trueChoose = 'B';
		}
		finish = true;;
	}

}
