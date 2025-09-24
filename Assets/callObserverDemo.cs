using UnityEngine;

using System;
namespace ObserverDesignPattern
{
    public class callObserverDemo : MonoBehaviour
    {
        [SerializeField] public GameObject mainSubjectGO;
        [SerializeField] public GameObject[] observer1GO;

        public Subject mainSubject;
        public Observer[] observer1;
        void Start()
        {
            mainSubject = new Subject(mainSubjectGO);
            observer1 = new Observer[observer1GO.Length];
            for (int i = 0; i < observer1GO.Length; i++)
            {
                observer1[i] = new Observer(observer1GO[i]);
                observer1[i].AddSubscriber(mainSubject);
                //edit fix check
            }


            Debug.Log("mainSubject current state : " + mainSubject.GetVisibility());

            // Now the product is available
            mainSubject.SetVisibility(true);
            Debug.Log("XXXXXXXXXXXnew set visibilityXXXXXXXXXXXXX");
            mainSubject.SetVisibility(false);
            Debug.Log("XXXXXXXXXXXnew set visibilityXXXXXXXXXXXXX");
            mainSubject.SetVisibility(true);
            Debug.Log("mainSubject current state : " + mainSubject.GetVisibility());

            //Console.Read();
        }
    }
}