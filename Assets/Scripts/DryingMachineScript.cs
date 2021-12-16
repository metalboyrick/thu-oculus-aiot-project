
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DryingMachineScript : MonoBehaviour
{
    bool isOpen = false;
    GameObject washingHatch;
    
    // Start is called before the first frame update
    void Start()
    {
        washingHatch = GameObject.Find("DryingHatch");
    }

    // Update is called once per frame
    void Update()
    {
        if(isOpen)
        {
            Quaternion target = Quaternion.Euler(0, 0, -90);
            washingHatch.transform.localRotation = target;
        }
        else 
        {
            Quaternion target = Quaternion.Euler(0, 0, 0);
            washingHatch.transform.localRotation = target;
        }
    }

    public void OpenMachine()
    {
        isOpen = true;
        Debug.Log("Voice command detected");
    }
    
    public void CloseMachine()
    {
        isOpen = false;
    }
}
