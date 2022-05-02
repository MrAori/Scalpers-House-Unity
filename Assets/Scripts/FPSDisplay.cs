using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// https://forum.unity.com/threads/fps-counter.505495/ - Reference

public class FPSDisplay : MonoBehaviour
{
    public float timer, refresh, avgFrameRate;
    string display = "{0} FPS";
    private Text FPSText;
    
    private void Start (){
        FPSText = GetComponent<Text>();
    }

    private void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;

        if(timer <= -0) avgFrameRate = (int) (1f / timelapse);
        FPSText.text = string.Format(display,avgFrameRate.ToString());
    }
}
