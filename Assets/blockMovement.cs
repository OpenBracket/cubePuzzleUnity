using UnityEngine;
using System.Collections;

public class blockMovement : MonoBehaviour {

    public GameObject playerRight, playerLeft, playerTop, playerBottom;
    public Rigidbody2D player;
    public bool isConnected, shouldConnect;
    public int connectedSide;
    public BoxCollider2D col;

    int NONE = 0, TOP = 1, BOTTOM = 2, LEFT = 3, RIGHT = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (connectedSide == TOP)
        {
            this.transform.position = playerTop.transform.position;
        } else if (connectedSide == BOTTOM)
        {
            this.transform.position = playerBottom.transform.position;
        } else if (connectedSide == LEFT)
        {
            this.transform.position = playerLeft.transform.position;
        } else if (connectedSide == RIGHT)
        {
            this.transform.position = playerRight.transform.position;
        }

    }
}
