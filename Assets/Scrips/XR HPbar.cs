using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRHPbar : MonoBehaviour
{

    public GameObject[] cube;

    public void SetHp(int hp)
    {
        cube[hp].SetActive(false);
    }

}
