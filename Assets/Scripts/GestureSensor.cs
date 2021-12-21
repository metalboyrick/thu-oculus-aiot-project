using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GestureSensor : MonoBehaviour
{
    public UnityEvent startFn;
    public UnityEvent pauseFn;
    public UnityEvent stopFn;

    // -1 - no gesture
    //  0 - start
    //  1 - pause
    //  2 - stop
    int gestureActive = -1;
    float gestureHeld = 0;

    void Start()
    {
        if (startFn == null) startFn = new UnityEvent();
        if (pauseFn == null) pauseFn = new UnityEvent();
        if (stopFn == null) stopFn = new UnityEvent();
    }

    void Update()
    {
        // Calculate held time for gestures
        if (gestureActive != -1)
        {
            float gestureHeldPrev = gestureHeld;
            gestureHeld += Time.deltaTime;
            if (gestureHeld >= 2.0f && gestureHeldPrev < 2.0f)
            {
                switch (gestureActive)
                {
                    case 0:
                        startFn.Invoke();
                        break;
                    case 1:
                        pauseFn.Invoke();
                        break;
                    case 2:
                        stopFn.Invoke();
                        break;
                    default:
                        break;
                }
            }
        }
    }

    // Callbacks for gesture detection
    public void GestureTriggered(int gesture)
    {
        gestureActive = gesture;
        gestureHeld = 0;
    }
    public void GestureUntriggered()
    {
        gestureActive = -1;
        gestureHeld = 0;
    }
}
