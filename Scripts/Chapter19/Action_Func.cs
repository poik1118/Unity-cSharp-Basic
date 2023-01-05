using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// Action과 Func

public class Action_Func : MonoBehaviour
{
    delegate string MyDelegate<T1, T2>(T1 arg1, T2 arg2);
    MyDelegate<int, int> myDelegate;

    Action<int, int> myDelegate2;   // public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
    Func<int, int, string> myDelegate3;     // public delegate TResult Func<in T, out TResult>(T arg);
    void Start()
    {
        myDelegate3 = (int arg1, int arg2) => { int sum = arg1 + arg2; return sum + "이 리턴 되었습니다."; };
        print(myDelegate3(3,5));
    }
}
