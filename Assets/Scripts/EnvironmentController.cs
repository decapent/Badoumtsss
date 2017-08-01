using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Linq;

public class EnvironmentController : MonoBehaviour {

    private List<string> gameObjectTags = new List<string>
    {
        "BassDrum" ,
        "FloorTom" ,
        "HiHat" ,
        "Ride" ,
        "Crash" ,
        "Throne" ,
        "Snare" ,
        "RackTom" ,
        "LeftStick",
        "RightStick",
        "KickPedal"
    };

    private Dictionary<string, Vector3> initialPositions = new Dictionary<string, Vector3>();
    private Dictionary<string, Quaternion> initialRotations = new Dictionary<string, Quaternion>();

    // Use this for initialization
    void Start ()
    {
	    foreach(var tag in this.gameObjectTags)
        {
            var gameObject = GameObject.FindGameObjectWithTag(tag);
            if(gameObject != null)
            {
                this.initialPositions.Add(tag, gameObject.transform.position);
                this.initialRotations.Add(tag, gameObject.transform.rotation);
            }
        }
	}
	
	void Update ()
    {
        if (OVRInput.Get(OVRInput.Button.Four))
        {
            this.ResetEnvironment();
        }
    }

    private void ResetEnvironment()
    {
        foreach(var tag in this.gameObjectTags)
        {
            var gameObject = GameObject.FindGameObjectWithTag(tag);
            if(gameObject != null)
            {
                gameObject.transform.position = this.initialPositions[tag];
                gameObject.transform.rotation = this.initialRotations[tag];
            }
        }
    }
}
