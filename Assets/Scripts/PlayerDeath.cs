using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{   
    public SpriteRenderer spriteRenderer1;
    public SpriteRenderer spriteRenderer2;
    public Sprite solarPanelSlotSprite;
    public Transform PlayerTransform;
    int deathCount = 0;
    public GameObject solarPanel1;
    public GameObject solarPanel2;
    void spriteChange2() {
        spriteRenderer1.sprite = solarPanelSlotSprite;
        spriteRenderer2.sprite = solarPanelSlotSprite;
    }
    public void restart() {
        Item.itemPickup = false;
        solarPanel1.SetActive(true);
        solarPanel2.SetActive(true);
        spriteChange2();
        Recepticle1.completionRequirements[0] = 0;
        Recepticle1.completionRequirements[1] = 0;
        Recepticle1.done1 = false;
        Recepticle2.done = false;
    }
    void Update()
    {
        if(PlayerTransform.position.y <= -9.75) {
            // death
            deathCount++;
            Debug.Log("The player has died " + deathCount + " time/s!");
            PlayerTransform.position = new Vector2(0, -3);
            restart();
        }
    }
}
