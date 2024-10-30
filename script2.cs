using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    void Start()
    {
        string[] words = {"Cat","Dog","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird"};
        string generatedSentence = "";
        int counter = 0;

        while (counter < 7)
        {
            int randomIndex = Random.Range(0, words.Length);

            string randomWord = words[randomIndex];

            generatedSentence += randomWord + " ";
            counter++;

        }

        Debug.Log(generatedSentence);

        void Update()
        {

        }
    }
}
