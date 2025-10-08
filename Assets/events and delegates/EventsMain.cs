using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsMain : MonoBehaviour
{
    public event EventHandler<OnEPressedEventArgs> OnEPressed;
    public event EventHandler<OnRPressedEventArgs> OnRPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public class OnEPressedEventArgs : EventArgs
    {
        public int seedCount;
        public int totalSeedCount;
    }
    public class OnRPressedEventArgs : EventArgs
    {
        public int seedCount;
    }

    private int seedCount;
    private int totalSeedCount;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            seedCount++;
            totalSeedCount++;
            OnEPressed?.Invoke(this, new OnEPressedEventArgs { seedCount = seedCount, totalSeedCount = totalSeedCount });
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (seedCount > 0)
            {
                seedCount--;
                OnRPressed?.Invoke(this, new OnRPressedEventArgs { seedCount = seedCount });
            }
        }
    }
}
