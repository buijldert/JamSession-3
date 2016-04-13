using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MyTimer : MonoBehaviour
{


    
    private Text timertext;
    private int myTimer2 = 3;


    void Start()
    {
        timertext = GetComponent<Text>();
        PlayerTwoMovement.speed2 = 0;
        PlayerMovement.speed = 0;
        StartCoroutine(timerfunction());
    }


    void Update()
    {
        timertext.text = "" + myTimer2;

        if (myTimer2 >0)
        {


            
            



        }


    }

    IEnumerator timerfunction()
    {
        while (myTimer2 > 0)
        {
            yield return new WaitForSeconds(1);
            myTimer2 -= 1;
        }

        if (myTimer2 == 0)
        {
            timertext.enabled = false;
            PlayerTwoMovement.speed2 = .2f;
            ChangeSpeed.canMove = true;
            PlayerMovement.speed = .2f;
        }
       



    }
}