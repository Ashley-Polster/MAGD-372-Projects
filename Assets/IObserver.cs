using UnityEngine;

namespace ObserverDesignPattern
{
    // The Observer Interface
    public interface IObserver
    {
        // Receive Notification from Subject
        void UpdateVisibility(bool visibility);
    }
}