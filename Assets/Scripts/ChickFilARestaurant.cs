using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickFilARestaurant : MonoBehaviour
{
    public string[] menuItems = {"Spicy Deluxe", "Original", "Grilled Chicken Wrap"};
    public string greeting = "Hello, welcome to Chick Fil A";
    
    void Start()
    {
        TakeOrder();
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
