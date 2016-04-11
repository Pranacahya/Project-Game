using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed =10;
	public PlayerAnimator myAnim;
	Rigidbody2D myBody;
	float hinput = 0;
	float vinput = 0;
	void Start () 
	{
		myBody = GetComponent<Rigidbody2D>();
		//myAnim = PlayerAnimator.instance;
	}
	void Update () 
	{
		myAnim.UpdateX (hinput);
		myAnim.UpdateY (vinput);
		Move (hinput,vinput);
		print ("masuk");

	}

	void Move(float horizontalinput,float verticalinput)
	{
		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizontalinput * speed;
		moveVel.y = verticalinput * speed;
		myBody.velocity = moveVel;
	}
	public void setX(float x)
	{
		hinput = x;
		myAnim.UpdateX (x);
	}
	public void setY(float y)
	{
		vinput = y;
		myAnim.UpdateY (y);
	}
}
