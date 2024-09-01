using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject calculatScreen;
    [SerializeField] private GameObject comprasionScreen;

    private GameObject currentScreen;
    private void Start()

    {
        calculatScreen.SetActive(true);
        currentScreen = calculatScreen;

    }
    public void ChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            if (currentScreen = calculatScreen)
            {
                currentScreen.SetActive(false);
                state.SetActive(true);
                currentScreen = state;
            }
            if (currentScreen = comprasionScreen);
            {
                currentScreen.SetActive(false);
                state.SetActive(true);
                currentScreen = comprasionScreen;
            }
        }


    }
}