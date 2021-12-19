
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashMachineScript : MonoBehaviour
{
    bool isOpen = false;
    bool isRunning = false;
    GameObject washingHatch;
    
    // Start is called before the first frame update
    void Start()
    {
        washingHatch = GameObject.Find("WashingHatch");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OpenMachine()
    {
        // opens the machine
        if (!isOpen && !isRunning)
        {
            Quaternion target = Quaternion.Euler(0, 0, -90);
            washingHatch.transform.localRotation = target;
        }
        isOpen = true;
    }
    
    public void CloseMachine()
    {
        if (isOpen && !isRunning)
        {
            Quaternion target = Quaternion.Euler(0, 0, 0);
            washingHatch.transform.localRotation = target;
        }
        isOpen = false;
    }

    public void StartMachine()
    {
        isRunning = true;
    }

    public void StopMachine()
    {
        isRunning = false;
    }   
}
