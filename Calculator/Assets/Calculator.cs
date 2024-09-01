using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using System;
using JetBrains.Annotations;


public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField firstNum;
    [SerializeField] private InputField secondNum;
    [SerializeField] private Text text;


    public void Start() {
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

    public void Addition()
    {


        double firstNumber = Convert.ToDouble(firstNum.text);
        double secondNumber = Convert.ToDouble(secondNum.text);
        double equialsNumber = firstNumber + secondNumber;

        text.text = equialsNumber.ToString();

    }
    public void Subtraction()
    {
     

       double firstNumber = Convert.ToDouble(firstNum.text);
       double secondNumber = Convert.ToDouble(secondNum.text);
       double equialsNumber = firstNumber - secondNumber;

        text.text = equialsNumber.ToString();

    }
    public void Multiplication()
    {
        
        double firstNumber = Convert.ToDouble(firstNum.text);
        double secondNumber = Convert.ToDouble(secondNum.text);
        double equialsNumber = firstNumber * secondNumber;

        text.text = equialsNumber.ToString();

    }
    public void Division()
    {
       

        double firstNumber = Convert.ToDouble(firstNum.text);
        double secondNumber = Convert.ToDouble(secondNum.text);

        if (firstNumber != 0 && secondNumber != 0) {
            double equialsNumber = firstNumber / secondNumber;

            text.text = equialsNumber.ToString();

        }
        else { 
            text.text = "Ошибка: Деление на 0";
        }

    }
}
