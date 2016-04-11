using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour 
{
	///public static PlayerAnimator instance;

	static Transform myTrans;
	static Animator myAnim;
	Vector3 artScaleCache;

	void Start () 
	{
		myTrans = this.transform;
		myAnim = this.gameObject.GetComponent<Animator> ();
		//instance = this;

		artScaleCache = myTrans.localScale;
	}

	void FlipArt(float currentX)
	{
		if((currentX < 0 && artScaleCache.x == 1)|| 
		   (currentX > 0 && artScaleCache.x == -1))
		{
			artScaleCache.x*= -1;
			myTrans.localScale = artScaleCache;
		}
	}
	public void UpdateX (float currentX) 
	{

		FlipArt (currentX);
		myAnim.SetFloat ("Horizontal",currentX);

	}
	public void UpdateY (float currentY) 
	{
		myAnim.SetFloat ("Vertical",currentY);
	}
}
