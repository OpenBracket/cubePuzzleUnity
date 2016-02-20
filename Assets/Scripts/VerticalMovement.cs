using UnityEngine;
using System.Collections;

public class VerticalMovement : MonoBehaviour {
	public float Speed = 0f;
	public float jump = 0f;
	private float movex = 0f;
	private float movey = 0f;
	private float yVel = 0f;

	Rigidbody2D player;

	// Use this for initialization
	void Start()
	{
		player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	

		if(Input.GetKeyDown(KeyCode.Space))
		{
			player.AddForce (new Vector2(0,jump), ForceMode2D.Impulse);

		}



	}
}
