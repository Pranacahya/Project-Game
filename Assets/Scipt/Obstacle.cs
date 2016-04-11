using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Obstacle : MonoBehaviour {

	public _GM GM;
	public QuestionControl problem;

	public GameObject toolImg;
	public GameObject pathImg;
	public GameObject bagImg;
	public Animator ToolAnimator;

	public trigger TriggerTool;
	public trigger TriggerPath;

	public bool triggeredTool;
	public bool triggeredPath;

	public bool destroy_path_able;
	public bool get; 
	public bool opened;


	void Start () 
	{
		opened = false;
		get = false;
		bagImg.SetActive (false);
	}
	void FixedUpdate()
	{
		triggeredTool = TriggerTool.triggered;
		triggeredPath = TriggerPath.triggered;
	}
	
	public IEnumerator poof(float time) 
	{
		ToolAnimator.SetBool("Poof",true);
		toolImg.SetActive (false);
		yield return new WaitForSeconds(time);
		ToolAnimator.SetBool("Poof",false);
	}
	public void ToolClickA()
	{
		if (triggeredTool&&!get) 
		{
			StartCoroutine(GM.WaitTimePopUp(1,"Finish Key Get"));
			get=true;
			StartCoroutine(poof(1));
			bagImg.SetActive (true);
			
		}
	}
	public void PathClickA()
	{
		if (triggeredPath&&get) 
		{
			StartCoroutine(GM.WaitTimePopUp(1,"Door Opened"));
			opened=true;

			problem.QuestionCanvas.enabled = true;
			if(destroy_path_able)
				Destroy(pathImg);
		}
	}
	public void PathClickB()
	{
		if (triggeredPath&&get) 
		{
			problem.QuestionCanvas.enabled = false;
			opened=false;
		}
	}

}
