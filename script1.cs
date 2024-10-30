using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    
    void Start()
    {
        int counter = 0;
        while (true)
        {
           int randomNum=Random.Range(1, 21);
            
            if (randomNum == 5)
            {
                continue;
            }
            else if (randomNum == 15)
            {
                break;
            }
            Debug.Log(randomNum);
            counter++;


        }
       
    }


    void Update()
    {
        
    }
}
