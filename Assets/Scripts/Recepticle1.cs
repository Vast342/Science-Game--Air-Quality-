using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recepticle1 : MonoBehaviour
{
    static public bool done1;
    static public int[] completionRequirements = new int[2];
    public Collider2D self;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void spriteChange1()
    {
        spriteRenderer.sprite = newSprite; 
    }
    static public bool completion;
    void Update(){
        if(completionRequirements[0] == 1 && completionRequirements[1] == 1){
            Debug.Log("Minigame Complete!");
            completion = true;
        } else {
            completion = false;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D self)
    {
        if(Item.itemPickup == true && completionRequirements[0] == 0 && done1 == false){
             Debug.Log("Item 1 Detected!");
             Item.itemPickup = false;
             spriteChange1();
             completionRequirements[0] = 1;
             done1 = true;
        }else if(Item.itemPickup == true && completionRequirements[0] == 1 && done1 == false){
             Debug.Log("Item 2 Detected!");
             Item.itemPickup = false;
             spriteChange1();
             completionRequirements[1] = 1;
             done1 = true;
        }else if(done1 == false){
            Debug.Log("Item Not Detected!");
        }else if(Item.itemPickup == false && done1 == true){
            Debug.Log("Receptacle In Use And No Item Detected!");
        }else if(done1 == true){
            Debug.Log("Receptacle Already Used!");
        }
    }
}