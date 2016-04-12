using UnityEngine;
using System.Collections;

public class ChangeSpriteImage : MonoBehaviour {

    private SpriteRenderer _spriteRenderer;
    [SerializeField]private Sprite _speedUpImage;

	// Use this for initialization
	void Start () {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeToSpeedUp();
        }
	}

    void ChangeToSpeedUp()
    {
        _spriteRenderer.sprite = _speedUpImage;
    }
}
