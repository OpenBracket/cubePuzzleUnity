using UnityEngine;
using System.Collections;

public class control2 : MonoBehaviour {

    public float Speed = 0f;
    public float jump = 0f;
    private float movex = 0f;
    private float movey = 0f;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (player.velocity.y == 0)
                player.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

        //movey = Input.GetAxis("Vertical");
        player.velocity = new Vector2(movex * Speed, player.velocity.y);
    }
}
