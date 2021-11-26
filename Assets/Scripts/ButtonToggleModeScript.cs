using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonToggleModeScript : MonoBehaviour
{
    
    public TextMeshPro textComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeMode(string mode)
    {
        textComponent.text = "Selected Mode: " + mode;
        Debug.Log("Selected Mode: " + mode);
    }
}
