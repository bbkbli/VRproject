using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{

    // �Ѿ��� ���� - ������ [����]
    //1�� 2�� 3��

    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;
    public TMP_Text txtBulletCount;

    public void Start()
    {
        RefreshBulletCountUI();
    }


    //�Ѿ��� �߻� - ��� [�Լ�]
    //���� ���

    public void Shoot()
    {

        if(bulletCount <= 0)
        {
            return;
        }

        //������Ʈ�� ����
        //Instantiate(bullet);

        //������Ʈ�� ���� - firePos ���ʿ� ��ġ
        //Instantiate(bullet, firePos);

        //������Ʈ�� ���� -Vector�� ��ġ, Quaternion�� ȸ����
        Rigidbody bullet0Oj = Instantiate(bullet, firePos.position, firePos.rotation);
        bullet0Oj.AddForce(firePos.forward * 100, ForceMode.Impulse);

        bulletCount--;

        RefreshBulletCountUI();
    }

    void RefreshBulletCountUI()
    {
        txtBulletCount.text = bulletCount.ToString();
    }
}
