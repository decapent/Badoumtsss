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
    bool statIsHidden = true; 

    void Start()
    {
        latencyData = OVRManager.display.latency;
        
    }

    void Update()
    {

        if (Input.GetButtonDown("DevelopStat"))
        {
            if(statIsHidden)
                HideInfomation();
            else
                ShowInfomation();
        }


        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

        latency.text = string.Format("Latency : {0:0.00} ms", latencyData.render);            

        fps.text = string.Format("FPS : {0}", deltaTime);





    }


    void HideInfomation()
    {
        fps.gameObject.SetActive(false);
        latency.gameObject.SetActive(false);
        statIsHidden = false;
    }

    void ShowInfomation()
    {
        fps.gameObject.SetActive(true);
        latency.gameObject.SetActive(true);
        statIsHidden = true;
    }

}
