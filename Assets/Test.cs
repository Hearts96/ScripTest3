using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{


    void Start()
    {

        int[] array = new int[5];
        array[0] = 40;
        array[1] = 30;
        array[2] = 50;
        array[3] = 20;
        array[4] = 10;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}