using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        // Get 3D sound component as the children of the current drum piece we are interacting with!
        this.GetComponentInChildren<OSPAudioSource>().Play();
    }
}
