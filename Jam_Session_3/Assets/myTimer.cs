using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class myTimer : MonoBehaviour
{


    
    private Text timertext;
    private int myTimer2 = 3;


    void Start()
    {
        timertext = GetComponent<Text>();
        Player2Movement.speed2 = 0;
        playerMovement.speed = 0;
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
            Player2Movement.speed2 = .2f;
            playerMovement.speed = .2f;
        }
       
    }
}