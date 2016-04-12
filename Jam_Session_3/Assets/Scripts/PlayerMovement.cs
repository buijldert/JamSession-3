using UnityEngine;
using System.Collections;

<<<<<<< HEAD:Jam_Session_3/Assets/playerMovement.cs
public class playerMovement : MonoBehaviour
{
=======
public class PlayerMovement : MonoBehaviour {
>>>>>>> origin/master:Jam_Session_3/Assets/Scripts/PlayerMovement.cs

    public static float speed;
    public static bool canMove = false;


    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector2.up * speed);
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (canMove == true)
        {
            if (other.tag == "speed")
            {
                Speedup();
            }
            if (other.tag == "Ground")
            {
                SpeedDown();
            }
        }
    }
    void Speedup()
    {
        speed = .4f;
        Debug.Log("SpeedUp");
    }
    void SpeedDown()
    {
        speed = .2f;
        Debug.Log("SpeedDown");
    }
}
