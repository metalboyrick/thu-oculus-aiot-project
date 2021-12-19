using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using TMPro;

public class ButtonToggleModeScript : MonoBehaviour
{
    
    public TextMeshPro textComponent;
    public GameObject timeSlider;
    public GameObject tempSlider;
    bool isVCMode = false;
    bool timerReached = true;
    float timer = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        timeSlider = GameObject.FindGameObjectWithTag("TimeSlider");
        tempSlider = GameObject.FindGameObjectWithTag("TempSlider");
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

        switch(mode) 
        {
            case "Jacket":
                timeSlider.GetComponent<PinchSlider>().SliderValue = 0.7f;
                tempSlider.GetComponent<PinchSlider>().SliderValue = 0.5f;
                break;
            case "Shoes":
                timeSlider.GetComponent<PinchSlider>().SliderValue = 0.5f;
                tempSlider.GetComponent<PinchSlider>().SliderValue = 0.3f;
                break;
            case "Regular":
                timeSlider.GetComponent<PinchSlider>().SliderValue = 0.3f;
                tempSlider.GetComponent<PinchSlider>().SliderValue = 0.1f;
                break;
            default:
                // code block
                break;
        }

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
