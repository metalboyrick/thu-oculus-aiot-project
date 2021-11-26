using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeShow : MonoBehaviour
{
    private bool timeStop = true;
    private TextMeshPro textMesh = null;
    float i = 0;
    int timeValue = -1;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
        textMesh.text = "00:00";
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("UIButtonToggleIconOff_Time") == null)
        {
            if(timeValue == -1)
            {
                string text = GameObject.Find("SliderValueTime").GetComponent<TextMeshPro>().text;
                textMesh.text = text;
                timeValue = int.Parse(text.Split(':')[0]) * 60 + int.Parse(text.Split(':')[1]);
            }
            if(timeValue == 0)
            {
                GameObject.Find("PressableButtonHoloLens2ToggleSwitch_32x96_Time").GetComponent<PhysicalPressEventRouter>().OnHandPressTriggered();
            }
            if (i >= 1) 
            {
                timeValue -= 1;
                int minute = timeValue / 60;
                int second = timeValue % 60;
                if (second < 10)
                    textMesh.text = $"{minute}:0{second}";
                else
                    textMesh.text = $"{minute}:{second}";
                i = 0;

            } 
            i += Time.deltaTime;
        }
    }

}