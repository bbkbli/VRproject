using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public int Hp = 3;

    public GameObject Effect;

    //public TMP_Text txtCount;
    public XRHPbar hpBar;

    public void TryBomb()
    {
        Hp--;

        UpdateHPUI();

        if(Hp <= 0)
        {
            Instantiate(Effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void UpdateHPUI()
    {
        //txtCount.text = Hp.ToString();
        hpBar.SetHp(Hp);
    }

}
