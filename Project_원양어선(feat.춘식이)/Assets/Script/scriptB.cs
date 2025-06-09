using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptB : MonoBehaviour
{
    public Image img_HPbar;
    public int maxHP;
    float nowHP;

    public int Damage;
    public int HealPoint;
    void Awake()
    {
        nowHP = maxHP;
    }
    public void OnClickDamage()
    {
        nowHP -= Damage;
        if (nowHP <0)
        {
            nowHP = 0;
        }

        img_HPbar.fillAmount = nowHP / maxHP;
    }

    public void OnClickHeal()
    {
        nowHP += HealPoint;
        if (nowHP > maxHP)
        {
            nowHP = maxHP;
        }

        img_HPbar.fillAmount = nowHP / maxHP;

    }
}
