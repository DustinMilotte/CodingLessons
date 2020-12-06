using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChickFilARestaurant : MonoBehaviour
{
    public string[] menuItems = {"Spicy Deluxe", "Original", "Grilled Chicken Wrap"};
    public string greeting = "Hello, welcome to Chick Fil A";
    public GameObject greetingCanvas;
    public TextMeshProUGUI greetingText;
    
    void Start()
    {
        // TakeOrder();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayGreeting();
    }

    private void PlayGreeting()
    {
        greetingText.text = greeting;
        greetingCanvas.SetActive(true);
    }

    private void TakeOrder()
    {
        Say(greeting);
        EnterOrder();
    }

    private void DeliverOrderToTable()
    {
        // walk to the table
        // set down the food
    }
    
    private void EnterOrder()
    {
        throw new System.NotImplementedException();
    }
    private void Say(string greeting)
    {
        
    }
}
