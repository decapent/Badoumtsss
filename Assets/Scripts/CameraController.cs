using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        this.offset = this.transform.position - this.player.transform.position;
	}
	
	// LateUpdate is called once per frame and guarantees to run after all other objects
    // are done being animated.
	void LateUpdate ()
    {
        this.transform.position = this.player.transform.position + offset;
	}
}
