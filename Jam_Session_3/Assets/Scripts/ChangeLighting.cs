using UnityEngine;
using System.Collections;

public class ChangeLighting : MonoBehaviour {

    private Light _spotlight;

	// Use this for initialization
	void Start () 
    {
        _spotlight = gameObject.GetComponentInChildren<Light>();
        _spotlight.enabled = false;
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
        _spotlight.enabled = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _spotlight.enabled = false;
    }

}
