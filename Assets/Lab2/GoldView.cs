using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldView : MonoBehaviour
{
    [SerializeField] GameObject _textGold;
    [SerializeField] private SwordsBuy _swordBuy;

    private Cash _cash => GetComponent<Cash>();
    private Income _income => GetComponent<Income>();
    

    private void OnEnable() { _income.GoldChanged += DisplayGold;
                              _swordBuy.GoldChanged += DisplayGold;
    }
    private void OnDisable() { _income.GoldChanged -= DisplayGold; 
                               _swordBuy.GoldChanged -= DisplayGold; }

    void DisplayGold()
    {
        _textGold.GetComponent<TextMeshProUGUI>().text = _cash.Gold.ToString();
    }

}
