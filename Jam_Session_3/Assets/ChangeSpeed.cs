using UnityEngine;
using System.Collections;

public class ChangeSpeed : MonoBehaviour {

    public static bool canMove = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (canMove == true)
        {
            if (other.tag == "player1")
            {
                SpeedUpPOne();
            }
            if (other.tag == "player2")
            {
                SpeedUpPTwo();
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "player1")
        {
            SpeedDownPOne();
        }

        if(other.tag == "player2")
        {
            SpeedDownPTwo();
        }
    }

    void SpeedUpPOne()
    {
        PlayerMovement.speed = .4f;
    }

    void SpeedDownPOne()
    {
        PlayerMovement.speed = .2f;
    }

    void SpeedUpPTwo()
    {
        PlayerTwoMovement.speed2 = .4f;
    }

    void SpeedDownPTwo()
    {
        PlayerTwoMovement.speed2 = .2f;
    }
}
