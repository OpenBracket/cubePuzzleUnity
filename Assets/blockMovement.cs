using UnityEngine;
using System.Collections;

public class blockMovement : MonoBehaviour {

    public static GameObject playerRight, playerLeft, playerTop, playerBottom;
    public bool isConnected;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(isConnected)
        {
            enableMovement();
        }

    }

    void enableMovement()
    {
        this.GetComponent<HorizontalMovement>().enabled = true;
        this.GetComponent<VerticalMovement>().enabled = true;
    }
}
