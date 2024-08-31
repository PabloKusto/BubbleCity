using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Text myText;
    [SerializeField] private InputField inputField;

    private int value = 0;

    private void Start()
    {
        value = UnityEngine.Random.Range(0, 201);

    }
    private void onCheck()
    {
        if (inputField.text.Equals(value.ToString()))
        { myText.text = "Вы выйграли автомобииииль!";
        }
    else if (Convert.ToInt32(inputField.text) > value)
        {
            myText.text = "Загаданное число меньше";

        }
        else if (Convert.ToInt32(inputField.text) < value)
        {
            myText.text = "Загаданное число больше" ;
        }
            
        }
    }