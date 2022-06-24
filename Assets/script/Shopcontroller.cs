using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shopcontroller : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] GameObject _pupup;
   
    
    public void ClickPlus()
    {
        if (GameManager.instance._money > GameManager.instance.selladomoney - 1)
        {
            GameManager.instance._money -= GameManager.instance.selladomoney;
            GameManager.instance._addMoney++;
            GameManager.instance.selladomoney += GameManager.instance.selladomoney;
        }
        else
        {
            _pupup.SetActive(true);
        }
    }
}
