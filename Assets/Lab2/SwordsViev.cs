using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SwordsViev : MonoBehaviour
{
    [SerializeField] GameObject _textSwords;

    private SwordsAmount _swordAmount => GetComponent<SwordsAmount>();
    private SwordsBuy _swordBuy => GetComponent<SwordsBuy>();

    private void OnEnable()
    {
        _swordBuy.SwordChanged += DisplaySwords;
    }
    private void OnDisable()
    {
        _swordBuy.SwordChanged -= DisplaySwords;
    }

    void DisplaySwords()
    {
        _textSwords.GetComponent<TextMeshProUGUI>().text = _swordAmount.Amount.ToString();
    }

}
