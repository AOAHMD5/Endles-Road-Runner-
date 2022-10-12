using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int currentWheelIndex = 0;
    public GameObject[] wheelModels;


    // Start is called before the first frame update
    void Start()
    {

        currentWheelIndex = PlayerPrefs.GetInt("SelectedWheel",0);
        foreach (GameObject wheel in wheelModels)
            wheel.SetActive(false);

        wheelModels[currentWheelIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        wheelModels[currentWheelIndex].SetActive(false);

        currentWheelIndex++;
        if (currentWheelIndex == wheelModels.Length)
            currentWheelIndex = 0;

        wheelModels[currentWheelIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedWheel", currentWheelIndex);
    }

    public void Previous()
    {
        wheelModels[currentWheelIndex].SetActive(false);

        currentWheelIndex--;
        if (currentWheelIndex == -1)
            currentWheelIndex = wheelModels.Length - 1;

        wheelModels[currentWheelIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedWheel", currentWheelIndex);
    }
}
