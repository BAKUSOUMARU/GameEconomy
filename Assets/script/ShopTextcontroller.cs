using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTextcontroller : MonoBehaviour
{
    [SerializeField] Text _sohptext;
    [SerializeField] SohpTextchange _sohpchange;
    // Update is called once per frame
    void Update()
    {
        SohpText();
    }

    void SohpText()
    {
        switch (_sohpchange)
        {
            case SohpTextchange.AdoMoney:
                _sohptext.text = GameManager.instance.selladomoney.ToString() + "‰~";   
                break;
            case SohpTextchange.AutoMonwy:
                break;
            default:
                break;
        }
    }

    enum SohpTextchange
    {
        AdoMoney,
        AutoMonwy
    }
}
