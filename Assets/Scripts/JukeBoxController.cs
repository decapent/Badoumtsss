using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeBoxController : MonoBehaviour {

    private bool isPlaying = true;
    private OSPAudioSource jukeboxSoundSource;

    // Use this for initialization
    void Start ()
    {
        jukeboxSoundSource = this.GetComponentInChildren<OSPAudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(isPlaying)
        {
            this.jukeboxSoundSource.Stop();
        }
        else
        {
            this.jukeboxSoundSource.Play();
        }

        isPlaying = !isPlaying;
    }
}
