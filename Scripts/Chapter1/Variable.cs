using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    // 1 + 1 = 2 (���)
    // 1 + x = n (x = ����)
    int x = 100;

    int y = 100;
    int sum;

    void Start()
    {
        print(x);

        x = -500;
        print(x);

        x = x + 500;
        print(x);

        sum = x + y;
        print(sum);
        print(-sum);
    }
}
