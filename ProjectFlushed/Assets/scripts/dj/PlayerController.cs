/**
 * DJ
 * Rough Player Controller just to work some stuff out
 * Not even close to what we really need. I'm bad at making player controllers.
 * 
 * It's 2am and I'll comment later :P
 **/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float x_speed;
    public float y_speed;
    public Vector2 playerVelocity;
    private bool attemptMove;
    public float slow_time;

	// Use this for initialization
	void Start () {
        playerVelocity = Vector2.zero;
        attemptMove = false;
	}

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();

        //Input Handler
        if (Input.GetKey("w"))
        {
            playerVelocity.y = y_speed;
            attemptMove = true;
        }
        else if (Input.GetKey("s"))
        {
            playerVelocity.y = -y_speed;
            attemptMove = true;
        }
        else { attemptMove = false; }

        if (Input.GetKey("d"))
        {
            playerVelocity.x = x_speed;
            attemptMove = true;
        }
        else if (Input.GetKey("a"))
        {
            playerVelocity.x = -x_speed;
            attemptMove = true;
        }
        else { attemptMove = false; }

        if (!attemptMove)
        {
            playerVelocity = Vector2.Lerp(playerVelocity, Vector2.zero, slow_time);
        }
        

        rb.velocity = playerVelocity;
    }
}
