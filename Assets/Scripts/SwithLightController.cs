using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwithLightController : MonoBehaviour {

    public Light light;
    bool isLightOpened = true;

    // Use this for initialization
    void Start()
    {
        this.light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.Two))
        {
            //if (lightIsOpen)
            //    SwitchLight(false);
            //else
            //    SwitchLight(true);

            this.SwitchLight(isLightOpened);
        }
    }

    void SwitchLight(bool isActive)
    {
        light.enabled=isActive;
        isLightOpened = isActive;

        isLightOpened = !isLightOpened;
    }
}
