using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingLight : MonoBehaviour
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
            this.GetComponent<Light>().GetComponent<Light>().color = new Color(1, 0, 0);
        }
        else
        {
            this.GetComponent<Light>().GetComponent<Light>().color = new Color(0, 1, 0);
        }
    }
}
