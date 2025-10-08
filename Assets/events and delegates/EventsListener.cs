using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsListener : MonoBehaviour
{
    public GameObject plant;
    public Transform playerGroundCheck;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventsMain eventsMain = GetComponent<EventsMain>();
        eventsMain.OnEPressed += EventsMain_OnEPressed;
        eventsMain.OnRPressed += EventsMain_OnRPressed;
    }
    private void EventsMain_OnEPressed(object sender, EventsMain.OnEPressedEventArgs e)
    {
        Debug.Log("Seed obtained! Seeds: " + e.seedCount);
        if(e.totalSeedCount >= 10)
        {
            Debug.Log("No more seeds available!");
            EventsMain eventsMain = GetComponent<EventsMain>();
            eventsMain.OnEPressed -= EventsMain_OnEPressed;
        }
    }
    private void EventsMain_OnRPressed(object sender, EventsMain.OnRPressedEventArgs e)
    {
        Debug.Log("Seed planted! Seeds: " + e.seedCount);
        Instantiate(plant, playerGroundCheck.position, playerGroundCheck.rotation);
    }

}
