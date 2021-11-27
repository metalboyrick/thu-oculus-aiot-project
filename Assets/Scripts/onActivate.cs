using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onActivate : MonoBehaviour
{
    bool pressure = false;
    GameObject washingHatch;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (pressure)
        {
            GameObject.Find("WeightDetector").GetComponent<Renderer>().material.color = new Color(100, 0, 0);
        }
        else
        {
            GameObject.Find("WeightDetector").GetComponent<Renderer>().material.color = new Color(0, 0, 100);
        }
    }

    public void changeRed()
    {
        pressure = true;
    }

    public void changeBlue()
    {
        pressure = false;
    }
}
