using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MenuController2 : MonoBehaviour
{
    public GameObject solarPanel1;
    public GameObject solarPanel2;
    public GameObject solarPanelSlot1;
    public GameObject solarPanelSlot2;
    public Renderer spsTileMap;
    public GameObject Player;
    static public bool complete = false;
    public Transform playerTransform;
    public SpriteRenderer spriteRenderer1;
    public SpriteRenderer spriteRenderer2;
    public Sprite solarPanelSlotSprite;
    void spriteChange2() {
        spriteRenderer1.sprite = solarPanelSlotSprite;
        spriteRenderer2.sprite = solarPanelSlotSprite;
    }
    void restart() {
        Item.itemPickup = false;
        spriteChange2();
        Recepticle1.completionRequirements[0] = 0;
        Recepticle1.completionRequirements[1] = 0;
        Recepticle1.done1 = false;
        Recepticle2.done = false;
        solarPanel1.SetActive(true);
        solarPanel2.SetActive(true);
        playerTransform.position = new Vector2(0, -3);
        Time.timeScale = 1F;
    }
    void Update () {
        if(MenuSystem.state == "Game 1" && complete == false) {
            solarPanel1.SetActive(true);
            solarPanel2.SetActive(true);
            solarPanelSlot1.SetActive(true);
            solarPanelSlot2.SetActive(true);
            spsTileMap.enabled = true;
            Player.SetActive(true);
            complete = true;
            restart();
            Complete.completeCheck = false;
        } else if(complete == false) {
            solarPanel1.SetActive(false);
            solarPanel2.SetActive(false);
            solarPanelSlot1.SetActive(false);
            solarPanelSlot2.SetActive(false);
            spsTileMap.enabled = false;
            Player.SetActive(false); 
        }
    }
}
