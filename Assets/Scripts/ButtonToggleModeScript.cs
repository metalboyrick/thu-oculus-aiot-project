using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonToggleModeScript : MonoBehaviour
{
    
    public TextMeshPro textComponent;
    bool isVCMode = false;
    bool timerReached = true;
    float timer = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!timerReached && isVCMode)
            timer += Time.deltaTime;

        if (!timerReached && timer > 5)
        {
            Debug.Log("Done waiting");
            disableVoiceMode();

            //Set to false so that We don't run this again
            timerReached = true;
        }
    }

    public void OnChangeMode(string mode)
    {
        textComponent.text = "Selected Mode: " + mode;
        Debug.Log("Selected Mode: " + mode);
    }

    public void OnVoiceChangeMode(string mode)
    {
        if(isVCMode)
        {
            OnChangeMode(mode);
        }
    }

    public void enableVoiceMode()
    {
        isVCMode = true;
        timerReached = false;
    }

    public void disableVoiceMode()
    {
        isVCMode = false;
        timer = 0.0f;
    }
}
