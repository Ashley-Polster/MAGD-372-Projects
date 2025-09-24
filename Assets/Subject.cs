using UnityEngine;

using System;
using System.Collections.Generic;
namespace ObserverDesignPattern
{
    // The ConcreteSubject class
    // The Subject have states and notifies all observers when the state changes.
    public class Subject : MonoBehaviour, ISubject
    {
        [SerializeField] public List<IObserver> observers = new List<IObserver>();

        public GameObject subject;

        public Subject(GameObject initialSubject)
        {
            subject = initialSubject;
        }

        private bool Visibility { get; set; }

        public bool GetVisibility()
        {
            return Visibility;
        }

        public void SetVisibility(bool visibility)
        {
            this.Visibility = visibility;
            Debug.Log("Visibility changed.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Debug.Log("Observer Added");
            observers.Add(observer);
        }
        
        public void RemoveObserver(IObserver observer)
        {
            Debug.Log("Observer Removed");
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Debug.Log("Now visible" + Visibility);

            foreach (IObserver observer in observers)
            {
                //By Calling the Update method, we are sending notifications to observers
                observer.UpdateVisibility(Visibility);
            }
        }
    }
}