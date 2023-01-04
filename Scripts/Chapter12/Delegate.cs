using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ��������Ʈ


public class Delegate : MonoBehaviour
{
    public delegate void ChainFunction(int value);
    public static event ChainFunction OnStart;
    //ChainFunction chain;

    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power�� ����" + value + "��ŭ �����߽��ϴ�. �� power�� �� = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("defence�� ����" + value + "��ŭ �����߽��ϴ�. �� defence�� �� = " + defence);
    }

    void Start()
    {
        //SetPower(5);
        //SetDefence(5);

        /*
        chain += SetPower;      // chain�� SetPower�� ���´�.
        chain += SetDefence;    // chain�� SetDefence�� ���´�.
        chain(5);       // SetPower�� SetDefence�� 5�� �ִ´�.

        chain -= SetPower;
        chain -= SetDefence;
        chain(5);
        */

        OnStart += SetPower;
        OnStart += SetDefence;
    }

    private void OnDisable()        // ��ü�� ��Ȱ�� �Ǿ�����(���� �Ǿ�����) ȣ��
    {
        OnStart(5);
    }
}
