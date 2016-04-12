using UnityEngine;
using System.Collections;

public class PlayerTwoMovement : MonoBehaviour {

    public static float speed2;

    void Update()
    {

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
         //   transform.Translate(Vector2.right * speed2);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
            //transform.Translate(-Vector2.right * speed2);
        //}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.up * speed2);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector2.up * speed2);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Clockwise
            transform.Rotate(0, 0, -4.0f); // --> Instead of "transform.Rotate(-1.0f, 0.0f, 0.0f);"
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Counter-clockwise
            transform.Rotate(0, 0, 4.0f); // --> Instead of transform.Rotate(1.0f, 0.0f, 0.0f);
        }



    }
}
