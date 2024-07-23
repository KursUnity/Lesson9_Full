using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    // Создание диалога:

    public Text DialogText; // Переменная в которой будет идти диалог
    public string[] DialogMessage; // Массив строковых переменных для заполнения предложениями

    int arrayIndex = 0; // Индекс массива (что бы не писать цифры вручную)
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DialogText.text = DialogMessage[arrayIndex];

            if (arrayIndex < DialogMessage.Length - 1) // Если arrayIndex меньше длины массива. Это нужно, что бы имея массив из 2 элементов, мы не вызвали 3-ий
            { // Индекс массива начинается с нуля. Поэтому если длина массива 10, то последний элемент массива это 9. И для этого отнимаем от длины массива 1
                arrayIndex++;
            }
            else // Иначе обнуляем индекс. И диалог начинается заново
            {
                arrayIndex = 0;
            }
        }
    }
}
