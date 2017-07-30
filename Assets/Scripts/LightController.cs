using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Light light;
    // Use this for initialization
    void Start () {
        light = this.GetComponent<Light>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Flashlight"))
        {
            
            light.gameObject.SetActive(false);


        }

    }
}
