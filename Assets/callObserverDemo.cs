using UnityEngine;

using System;
namespace ObserverDesignPattern
{
    public class callObserverDemo : MonoBehaviour
    {
        [SerializeField] public GameObject mainSubjectGO;
        [SerializeField] public GameObject observer1GO;

        [SerializeField] public Subject mainSubject;
        [SerializeField] public Observer observer1;

        void Start()
        {
            mainSubject = new Subject(mainSubjectGO);
            observer1 = new Observer(observer1GO);

            observer1.AddSubscriber(mainSubject);

            Debug.Log("mainSubject current state : " + mainSubject.GetVisibility());

            // Now the product is available
            mainSubject.SetVisibility(true);
            observer1.UpdateVisibility(true);
            Debug.Log("mainSubject current state : " + mainSubject.GetVisibility());

            Console.Read();
        }
    }
}