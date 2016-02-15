using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

	Rigidbody2D cube;
	public float speed, jump;

	// Use this for initialization
	void Start () {
		cube = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D)) {
			//cube.MovePosition (cube.position + new Vector2(speed,0));
			cube.AddForce (new Vector2(speed,0), ForceMode2D.Impulse);
		}

		if (Input.GetKey (KeyCode.A)) {
			//cube.MovePosition (cube.position + new Vector2(-speed,0));
			cube.AddForce (new Vector2(-speed,0), ForceMode2D.Impulse);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if(cube.velocity.y == 0)
				cube.AddForce (new Vector2(0,jump), ForceMode2D.Impulse);
		}
	

	}
}
