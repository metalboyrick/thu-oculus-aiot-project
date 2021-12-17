using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSliderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("UIButtonToggleIconOff_Time") == null)
        {
            this.GetComponent<PinchSlider>().enabled = false;
        }
        else
        {
            this.GetComponent<PinchSlider>().enabled = true;
        }
    }
}
