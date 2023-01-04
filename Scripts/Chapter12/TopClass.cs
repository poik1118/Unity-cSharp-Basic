using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopClass : MonoBehaviour
{
    public void Test(int value)
    {
        print(value + "값이 증가했습니다.");
    }
    void Start()
    {
        Delegate.OnStart += Test;
    }
}
