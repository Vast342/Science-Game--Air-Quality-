using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{   
    static public bool completeCheck;
    static public bool done = false;
    public GameObject complete;
    public GameObject player;
    public GameObject sp1;
    public GameObject sp2;
    public GameObject SPS1;
    public GameObject SPS2;
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
        sp1.SetActive(true);
        sp1.SetActive(false);
        playerTransform.position = new Vector2(5, -6);
        Time.timeScale = 1F;
    }
    void Update()
    {
        StartCoroutine(wait());
        completeCheck  = Recepticle1.completion;
         IEnumerator wait() {
        if(completeCheck == true && done == false){
            complete.SetActive(true);
            player.SetActive(false);
            SPS1.SetActive(false);
            SPS2.SetActive(false);
            yield return new WaitForSecondsRealtime(5);
            // menu change
            player.SetActive(false);
            SPS1.SetActive(false);
            SPS2.SetActive(false);
            complete.SetActive(false);
            playerTransform.rotation = new Quaternion(0, 0, 0, 0);
            done = true;
            StopCoroutine(wait());
        } else if (Recepticle1.completion == false) {
            complete.SetActive(false);
       }
    }   
    }
}