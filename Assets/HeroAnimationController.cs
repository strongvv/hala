using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimationController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	int velocity = 20;
	void Update () {
		if ( Input.GetKey(KeyCode.LeftArrow) ) {
			velocity -= 10;
		}
		if ( Input.GetKey(KeyCode.RightArrow) ) {
			velocity += 10;
		}
        transform.Rotate(0, Time.deltaTime * velocity, 0);
    }
}
