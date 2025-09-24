using UnityEngine;

namespace ObserverDesignPattern
{
        // The Subject Interface
        public interface ISubject
        {
            // Register an observer to the subject.
            void RegisterObserver(IObserver observer);

            // Remove or unregister an observer from the subject.
            void RemoveObserver(IObserver observer);

            // Notify all registered observers when the state of the subject is changed.
            void NotifyObservers();
        }
}
