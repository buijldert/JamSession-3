using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    public static float speed;


    void Update() {

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * speed);
        }

        //if (Input.GetKey(KeyCode.W))
        //{
          //  transform.Translate(Vector2.up * speed);
       // }

        // if (Input.GetKey(KeyCode.S))
       // {
        //    transform.Translate(-Vector2.up * speed);
       //    }

        if (Input.GetKey(KeyCode.S))
        {
            // Clockwise
            transform.Rotate(0, 0, -3.0f); // --> Instead of "transform.Rotate(-1.0f, 0.0f, 0.0f);"
        }

        if (Input.GetKey(KeyCode.W))
        {
            // Counter-clockwise
            transform.Rotate(0, 0, 3.0f); // --> Instead of transform.Rotate(1.0f, 0.0f, 0.0f);
        }

    }
}
