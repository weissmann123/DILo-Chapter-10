using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    public float xInitialForce;
    public float yInitialForce;
    void Start()
    {
        Invoke("PushBall", 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void PushBall()
    {
        float constantSpeed = 1000;

        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        float randomDirection = Random.Range(0, 2);

        Vector2 test1 = new Vector2(-xInitialForce, yRandomInitialForce);
        Vector2 test2 = new Vector2(xInitialForce, yRandomInitialForce);
        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            player.velocity = player.velocity.normalized;
            player.AddForce(test1.normalized * constantSpeed);
        }
        else
        {
            player.velocity = player.velocity.normalized;
            player.AddForce(test2.normalized * constantSpeed);
        }
    }
}
