using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droneselector : MonoBehaviour
{

    public GameObject drone1;
    public GameObject drone2;

    public int droneSelected;

    void Start()
    {
        drone1.SetActive(true);
        drone2.SetActive(false);
        droneSelected=1;
    }

    public void drone_1 () {
        drone1.SetActive(true);
        drone2.SetActive(false);

        droneSelected=1;
    }
    
    public void drone_2 () {
        drone1.SetActive(false);
        drone2.SetActive(true);

        droneSelected=2;
    }


}

