using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class BtnClicker : MonoBehaviour
{
    public GameObject meow1;
    public GameObject meow2;
    /*public GameObject meow3;*/

    public void Start()
    {
        /*meow1 = GameObject.Find("NearMenu4x2");
        meow2 = GameObject.Find("EXPEREMENTALO4KA");*/
        print(meow1);
        meow2.SetActive(false); 
      /*  meow3.SetActive(false);*/
    }

    public void CreateSomething()
    {
        print(meow1);
        print(meow2);
        meow2.SetActive(true);
        meow1.SetActive(false);
    }

    public void HidePlate()
    {
        meow2.SetActive(false);
        meow1.SetActive(true);
    }

    /*public void ShowSettingsPlate()
    {
        meow3.SetActive(true);
    }*/

}
