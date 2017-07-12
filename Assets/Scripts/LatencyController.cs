using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LatencyController : MonoBehaviour
{

    public Text fps;
    public Text latency;

    float deltaTime = 0.0f;

    OVRDisplay.LatencyData latencyData;

    void Start()
    {
        latencyData = OVRManager.display.latency;
    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

        latency.text = string.Format("Latency : {0:0.00} ms", latencyData.render);            

        fps.text = string.Format("FPS : {0}", deltaTime);
    }
}
