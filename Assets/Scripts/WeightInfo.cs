using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float weightToDetergentRatio = 200;
        float weightFromSensor = GameObject.Find("WashingMachineWeightSensor").GetComponent<WashingMachineWeightScalerWidget>()._totalWeight;
        string weight = string.Format("{0:N2}", weightFromSensor * weightToDetergentRatio);
        SetWeight(weight + " ml");
    }

    public void SetWeight(string totalWeight)
    {
        GetComponent<TMPro.TextMeshPro>().text = totalWeight;
    }
}
