using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recepticle2 : MonoBehaviour
{
    static public bool done;
    public Collider2D self;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void spriteChange1()
    {
        spriteRenderer.sprite = newSprite; 
    }
    

    private void OnTriggerEnter2D(Collider2D self)
    {
        if(Item.itemPickup == true && Recepticle1.completionRequirements[0] == 0 && done == false){
             Debug.Log("Item 1 Detected!");
             Item.itemPickup = false;
             spriteChange1();
             Recepticle1.completionRequirements[0] = 1;
             done = true;
        }else if(Item.itemPickup == true && Recepticle1.completionRequirements[0] == 1 && done == false){
             Debug.Log("Item 2 Detected!");
             Item.itemPickup = false;
             spriteChange1();
             Recepticle1.completionRequirements[1] = 1;
             done = true;
        }else if(done == false){
            Debug.Log("Item Not Detected!");
        }else if(Item.itemPickup == false && done == true){
            Debug.Log("Receptacle In Use And No Item Detected!");
        }else if(done == true){
            Debug.Log("Receptacle Already Used!");
        }
    }
    
}