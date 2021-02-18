using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Collider2D self;
    public GameObject SolarPanel;
    static public bool itemPickup = false;
    private void OnTriggerEnter2D(Collider2D self)
    {
        if (itemPickup == false) {
            Debug.Log("Pickup!");
            SolarPanel.SetActive(false);
            itemPickup = true; 
    
        } else {
            Debug.Log("Inventory Full!");
        }
    }
    
}
