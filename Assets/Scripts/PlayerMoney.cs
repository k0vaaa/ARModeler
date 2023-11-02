using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney: MonoBehaviour
{
    [SerializeField] private int _moneyAmmount;
    [SerializeField] private TextMeshPro _moneySign;

    public void Start()
    {
        _moneySign.text = _moneyAmmount.ToString();
    }
    public void ProcessBuy()
    {
        if (_moneyAmmount - 1 < 0)
        {
            return;
        }
        _moneyAmmount -= 1;
        _moneySign.text = _moneyAmmount.ToString();
    }

    public bool CanBuy()
    {
        return _moneyAmmount - 1 >= 0;
    }   
}
