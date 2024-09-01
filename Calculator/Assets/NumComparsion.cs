using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NumComparsion : MonoBehaviour
{
    [SerializeField] private InputField firstNum;
    [SerializeField] private InputField secondNum;
    [SerializeField] private Text text;


    public void Start()
    {
        {
            firstNum.onEndEdit.AddListener(EditForInput);
            secondNum.onEndEdit.AddListener(EditForInput);
        }
        void EditForInput(string input)
        {
            string sanitizedInput = input.Replace('.', ',');

            if (firstNum.text == input)
            {
                firstNum.text = sanitizedInput;
            }
            else if (secondNum.text == input)
            {
                secondNum.text = sanitizedInput;
            }
        }
    }

    public void Comprasion()
    {
        double firstNumber = Convert.ToDouble(firstNum.text);
        double secondNumber = Convert.ToDouble(secondNum.text);


        if (firstNumber > secondNumber)
        {
            text.text = firstNumber.ToString() + "\n" + "Больше" + "\n" + secondNumber.ToString();

        }
        else if (secondNumber > firstNumber)
        {
            text.text = " " + firstNumber.ToString() + "\n" + "Меньше" + "\n" + secondNumber.ToString();
        }
        else if (firstNumber == secondNumber)
        {
            text.text = "Числа равны";
        }
       

    }
}