using UnityEngine;

using System;
namespace ObserverDesignPattern
{
    // The ConcreteObserver class
    // Concrete Observer react to the updates issued by the Subject 
    public class Observer : MonoBehaviour, IObserver
    {
        //The following Property is going to hold the observer's name
        //public string UserName { get; set; }

        public GameObject observerObject;

        //Creating the Observer
        public Observer(GameObject initialObserverObject)
        {
            observerObject = initialObserverObject;
        }

        //Registering the Observer with the Subject
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        //Removing the Observer from the Subject
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }

        //Observer will get a notification from the Subject using the following Method
        public void UpdateVisibility(bool visibility)
        {
            Debug.Log("Player is now visibile" + visibility);
        }
    }
}