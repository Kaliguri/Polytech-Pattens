using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordsBuy : MonoBehaviour
{
    [SerializeField] int _price;
    [SerializeField] Cash _cash;
    
    private SwordsAmount _swordsAmount => GetComponent<SwordsAmount>();
    public event Action GoldChanged;
    public event Action SwordChanged;

    public void Buy()
    {
        if (_cash.Gold >= _price) 
        { 
          _swordsAmount.Amount++;
          _cash.Gold -= _price; 
            
          GoldChanged.Invoke(); 
          SwordChanged.Invoke(); 
        }
    }

}
