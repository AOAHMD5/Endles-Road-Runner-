using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSelecter : MonoBehaviour
{
    public int currentWheelIndex = 0;
    public GameObject[] wheels;


    // Start is called before the first frame update
    void Start()
    {

        currentWheelIndex = PlayerPrefs.GetInt("SelectedWheel", 0);
        foreach (GameObject wheel in wheels)
            wheel.SetActive(false);

        wheels[currentWheelIndex].SetActive(true);
    }
     
}
