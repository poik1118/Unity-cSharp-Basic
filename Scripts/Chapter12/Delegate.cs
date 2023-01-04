using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 델리게이트


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
        print("power의 값이" + value + "만큼 증가했습니다. 총 power의 값 = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("defence의 값이" + value + "만큼 증가했습니다. 총 defence의 값 = " + defence);
    }

    void Start()
    {
        //SetPower(5);
        //SetDefence(5);

        /*
        chain += SetPower;      // chain에 SetPower을 묶는다.
        chain += SetDefence;    // chain에 SetDefence를 묶는다.
        chain(5);       // SetPower와 SetDefence에 5를 넣는다.

        chain -= SetPower;
        chain -= SetDefence;
        chain(5);
        */

        OnStart += SetPower;
        OnStart += SetDefence;
    }

    private void OnDisable()        // 객체가 비활성 되었을때(종료 되었을때) 호출
    {
        OnStart(5);
    }
}
