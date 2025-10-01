using UnityEngine;

namespace singletonDemo
{

    public class callSingleton : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Singleton test1 = Singleton.GetInstance();
            test1.changeLevel(3);
            test1.changeLevel(5);
            Debug.Log("Testing");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}