using UnityEngine;
using System.Collections;

public class SwipeTest : MonoBehaviour
{
	// gives an access to the player
	public GameObject player;

	public float maxTime;
	public float minSwipeDist;
	public float speed;

	// finger touches the screen
	float startTime;
	// finger lifts the screen
	float endTime;

	Vector3 startPos;
	Vector3 endPos;
	float swipeDistance;
	float swipeTime;

	void Update ()
	{
		// if finger touched device
		// at least one touch on screen
		if(Input.touchCount > 0)
		{
			// store touch in a variable of Touch type
			Touch touch = Input.GetTouch(0);

			if(touch.phase == TouchPhase.Began)
			{
				// storing the first touch to startTime variable
				// Time.time the time at the beginning of the frame
				startTime = Time.time;
				startPos = touch.position;

				// distance direction
			}
			else if(touch.phase == TouchPhase.Ended)
			{
				endTime = Time.time;
				endPos = touch.position;

				// distance between two points
				swipeDistance = (endPos - startPos).magnitude;
				swipeTime = endTime - startTime;

				// if the time is less than max time and the distance is grater than the minimum swipe distance
				if(swipeTime < maxTime && swipeDistance > minSwipeDist)
				{
					swipe();
				}
			}
		}
	}

	void swipe()
	{
		// check vertical or horizontal swipe
		Vector2 distance = endPos - startPos;

		// if vertical swipe distance is greater than horizontal swipe distance vertical swipe
		// difference between touch poings absolute value for positive value
		if(Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
		{
			Debug.Log("Horizontal swipe");

			// if the value is positive right swipe
			if(distance.x > 0)
			{
				Debug.Log("Right swipe");
				//player.GetComponent<PlayerMove>().Movement();

			}
			if(distance.x < 0)
			{
				Debug.Log("Left swipe");
				transform.Translate(speed * Time.deltaTime, 0,0);
			}					
		}
		else if(Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
		{
			Debug.Log("Vertical swipe");
			
			if(distance.y > 0)
			{
				// swip up player jumps
				Debug.Log("Up swipe");
				// accessing playeJump script component
				player.GetComponent<PlayerJump>().Jump();
			}
			if(distance.y < 0)
			{
				Debug.Log("Down swipe");
			}

		}
	}
}