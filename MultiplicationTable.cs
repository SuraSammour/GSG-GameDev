using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
   
    void Start()
    {

        

        int Multiply(int numOne,int numTwo)
        {
            return numOne * numTwo;
        }

        for (int i = 1; i <= 10; i++)
        {
            int result = Multiply(5, i);
            Debug.Log("5 * " + i + " = " + result);
        }


    }

  
}
