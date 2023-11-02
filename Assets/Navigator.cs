using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator : MonoBehaviour
{

    private BtnClicker _btnClicker;

    void Start()
    {
        _btnClicker = FindObjectOfType<BtnClicker>();
    }

    void Update()
    {
        
    }

    public void DoSomtn()
    {
        _btnClicker.CreateSomething();
    }
}
