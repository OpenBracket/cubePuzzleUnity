using UnityEngine;
using System.Collections;

public class blockMovement : MonoBehaviour {

    public GameObject playerRight, playerLeft, playerTop, playerBottom;
    public Rigidbody2D player;
    public bool isConnected, shouldConnect;
    public int connectedSide;

    int NONE = 0, TOP = 1, BOTTOM = 2, LEFT = 3, RIGHT = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (isConnected)
        {
            enableMovement();
           

        }

        if (!isConnected && shouldConnect)
        {
            setSide(TOP);
            isConnected = true;
        }

       

    }

    void enableMovement()
    {
        this.GetComponent<HorizontalMovement>().enabled = true;
        this.GetComponent<VerticalMovement>().enabled = true;
    }

    void setSide(int side)
    {
        if(side == TOP)
        {
            this.GetComponent<Rigidbody2D>().position = playerTop.transform.position;
        }
    }
}
