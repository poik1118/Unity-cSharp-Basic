using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopClass : MonoBehaviour
{
    public void Test(int value)
    {
        print(value + "���� �����߽��ϴ�.");
    }
    void Start()
    {
        Delegate.OnStart += Test;
    }
}
