using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 예외처리
public class Exception : MonoBehaviour
{
    int a = 5;
    int b = 0;
    int c;
    void Start()
    {
        try{            // 오류가 발생 할 것 같은 부분을 기입
            c = a / b;
        }
        catch(DivideByZeroException ie){    // 오류명에 따른 대체 함수 작성 // Exception : 모든 오류들, ie : 임의의 변수
            print(ie);
            b = 1;
            c = a / b;
        }   
        finally{        // 오류 발생 유무와 관계없이 실행되는 코드
            print(c);
        }

        throw new System.Exception("일부로 발생시킨 오류");     // 강제로 발생시키는 오류
    }
}
