using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class HorizontalMovement : MonoBehaviour {

	public float Speed = 0f;
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
	void FixedUpdate()
	{

		movex = Input.GetAxis("Horizontal");
		//movey = Input.GetAxis("Vertical");

		player.velocity = new Vector2(movex * Speed, yVel);

	}
}
