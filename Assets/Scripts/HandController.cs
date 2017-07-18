using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }	
        else
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.gray;
        }
	}
}
