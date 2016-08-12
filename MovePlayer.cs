using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
	public GameObject player;
	public float speed;

	Rigidbody2D rb;

	void Start ()
	{
		//this.Rigidbody2D
		rb = GetComponent<Rigidbody2D>();
	}

	public void Movement()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		//Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		//rb.AddForce(movement * speed);
		rb.AddForce((Vector2.right * speed) * moveHorizontal);

		// current velocity = new velocity
		//rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
	}
}