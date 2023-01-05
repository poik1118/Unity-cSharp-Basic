using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 코루틴 : 병렬형태 처럼 보이도록 만들 수 있다.

public class CoroutineTest : MonoBehaviour
{
    Coroutine myCoroutine1;
    Coroutine myCoroutine2;

    private IEnumerator myCoroutine;

    void Start()
    {
        //LoopA();
        //LoopB();
 
        myCoroutine1 = StartCoroutine(LoopX());
        myCoroutine2 = StartCoroutine(LoopY());

        myCoroutine = LoopZ();                  // 파라미터의 수가 많을때 용이
        StartCoroutine(myCoroutine);
        
        StartCoroutine("LoopY");                // 문자열은 제약들이 존재한다

        StartCoroutine(Wait());
    }

#region Loop
    void LoopA(){
        for (int a = 0; a < 100; a++){
            print("a의 값 = " + a);
        }
    }
    void LoopB(){
        for (int b = 0; b < 100; b++){
            print("b의 값 = " + b);
        }
    }

    IEnumerator LoopX(){
        for (int x = 0; x < 100; x++){
            print("x의 값 = " + x);
            yield return new WaitForSeconds(1f);  // yield return null : 1프레임 대기
        }
    }
    IEnumerator LoopY(){
        for (int y = 0; y < 100; y++){
            print("y의 값 = " + y);
            yield return new WaitForSeconds(1f);    // WaitForSeconds(n) : n초 대기
        }
    }

    IEnumerator LoopZ(){
        for (int z = 0; z < 100; z++){
            print("z의 값 = " + z);
            yield return new WaitForSeconds(1f);    // WaitForSeconds(n) : n초 대기
        }
    }
#endregion Loop

    IEnumerator Wait(){
        yield return new WaitForSeconds(1f);
        StopCoroutine(myCoroutine1);
        yield return new WaitForSeconds(1f);
        StopCoroutine(myCoroutine2);

        yield return new WaitForSeconds(1f);
        StopCoroutine(myCoroutine);

        StopCoroutine("LoopY");             // 문자열로 특정 함수 호출

        StopAllCoroutines();            // 동작중인 모든 코루틴을 중지시킨다
    }
}
