using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour 
{
	public Vector2 jumpForce;

	void Start () 
	{
		jumpForce = new Vector2(0f, 300f);
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
						Attack ();
		if (Input.GetKeyDown(KeyCode.UpArrow))
						Jump ();
	}

	void Jump()
	{
		//if(isGrounded)
			print ("pula");
			rigidbody2D.AddForce(new Vector2(0f, jumpForce.y));
	}

	void Attack()
	{
		//if(canAttack)
			print ("ataca");
			
	}
}
