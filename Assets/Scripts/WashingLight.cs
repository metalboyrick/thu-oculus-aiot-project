using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingLight : MonoBehaviour
{
    // Start is called before the first frame update
    float i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i >= 0.1)

        {

            if (GameObject.Find("UIButtonToggleIconOff_Time") == null)
            {
                this.GetComponent<Light>().GetComponent<Light>().color = new Color(1, 30 / 255f, 0);
            }
            else
            {
                this.GetComponent<Light>().GetComponent<Light>().color = new Color(0, 1, 0);
            }
            i = 0;

        }
        else
        {
            if (GameObject.Find("UIButtonToggleIconOff_Time") == null)
                this.GetComponent<Light>().GetComponent<Light>().color = new Color(0, 0, 0, 0);
        }
        i += Time.deltaTime;
        
    }
}
