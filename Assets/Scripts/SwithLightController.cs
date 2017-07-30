using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwithLightController : MonoBehaviour {

    public Light light;
    bool lightIsOpen = true;

    // Use this for initialization
    void Start() {
        this.light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Flashlight"))
        {
            if (lightIsOpen)
                SwitchLight(false);
            else
                SwitchLight(true);
        }

    }

    void SwitchLight(bool isActive)
    {
        light.enabled=isActive;
        lightIsOpen = isActive;
    }
}
