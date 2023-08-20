using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//                 0   1   2   3   4
         int[] array = { 11, 22, 33, 44, 55 };
        for (int KK = 0; KK < 5; KK++)
        {
            Debug.Log(array[KK]);
        }
        for (int MY = 5; MY != 0; MY--)
        {
            Debug.Log(array[MY - 1]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
