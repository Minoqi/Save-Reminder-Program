using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    //Variables
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When Click Start, Calculate Time & Start Timer
    private void OnMouseDown()
    {
        manager.GetComponent<Manager>().CalculateTotalTime();
        manager.GetComponent<Manager>().StartTimerFunction();
    }
}
