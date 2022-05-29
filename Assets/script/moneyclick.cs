using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyclick : MonoBehaviour
{
    public void Click()
    {
        GameManager.instance._money += GameManager.instance._addMoney;
    }
}
