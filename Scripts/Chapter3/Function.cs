using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    int intValue;

    float floatValue = 10.5f;
    float floatValue2 = 20.5f;

    void Conversion(float _parameter)
    {
        intValue = (int)_parameter;
        print(intValue);
    }

    void FloatAddition(float _parameter, float _parameter2, string _strParameter = "default")
    {
        intValue = (int)(_parameter) + (int)(_parameter2);
        print(intValue);

        intValue = (int)(_parameter + _parameter2);
        print(intValue);

        print(_strParameter);
    }

    int FloatAddition2(float _parameter, float _parameter2)
    {
        //intValue = (int)(_parameter + _parameter2);
        //print(intValue);

        return (int)(_parameter + _parameter2);
    }

    int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }

    void Start()
    {
        Conversion(floatValue);
        print(floatValue);

        Conversion(floatValue2);
        print(floatValue2);

        FloatAddition(floatValue, floatValue2, "Float Addition Test");

        intValue = FloatAddition2(floatValue, floatValue2);
        print(intValue);

        print(FloatAddition2(floatValue, floatValue2));

        print(Multiply(FloatAddition2(floatValue, floatValue2)));
    }
}
