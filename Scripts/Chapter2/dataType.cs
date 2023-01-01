using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataType : MonoBehaviour
{
    // Integer data type
    //sbyte b = 200;                  // sbyte    = 1 bytes = -128 to 127
    //short s = 400000;               // short    = 2 bytes = -32,768 to 32,767
    //int i = 4000000000;             // int      = 4 bytes = -2,147,483,648 to 2,147,483,647
    //long l = 10000000000000000000;  // long     = 8 bytes = -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

    // Real number data type
    //float f = 0.00000001;           // float    = 4 bytes = Sufficient for storing 6 to 7 decimal digits
    //double d = 0.0000000000000001;  // double   = 8 bytes = Sufficient for storing 15 decimal digits

    // Text data type
    //string s = "asd¤±¤¤¤·!@#";      // string   = 4 bytes = Store a sequence of characters 
    //char c = 'a';                   // char     = 2 bytes = Stores a single character/letter or ASCII values


    //int a = 100;
    //long b = 100;
    //int sum;

    //int a = 100;
    //float b = 100.5f;
    //int sum1;
    //float sum2;

    //int a = 100;
    //string b;

    int a;
    string b = "100";


    void Start()
    {
        //sum = a + b;              // Cannot calculate between different operators

        //sum1 = (int)(a + b);      // Forced Type Conversion
        //sum2 = a + b;             // float = int + float
        //print(sum1);
        //print(sum2);

        //b = a.ToString();         // int a = 100 -> string a = "100"
        //print(b);

        a = int.Parse(b);           // string b = "100" -> int b = 100
        print(a);
    }
}
