using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeboxController : MonoBehaviour {

    bool isJukeboxPlaying = true;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            this.toggleJukeBox(isJukeboxPlaying);
        }
    }

    private void toggleJukeBox(bool isPlaying)
    {
        OSPAudioSource jukeboxSoundSource = this.GetComponentInChildren<OSPAudioSource>();

        if (!isPlaying)
        {
            jukeboxSoundSource.Stop();
        }
        else
        {
            jukeboxSoundSource.Play();
        }

        this.isJukeboxPlaying = !this.isJukeboxPlaying;
    }
}
