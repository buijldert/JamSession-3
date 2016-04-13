using UnityEngine;
using System.Collections;

public class DontDestroyObjectOnLoad : MonoBehaviour
{
    void Awake () 
    {
        DontDestroyOnLoad(this);
	}
}
