using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSystem : MonoBehaviour
{
    static public string state = "menu";
    public GameObject text1;
    public GameObject text3;
    public GameObject pollutantInfo;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public int[] position1 = { -503, -313 };
    public int[] position2 = { -343, -313 };
    public int[] position3 = { -183, -313 };
    public RectTransform button1Transform;
    public RectTransform button2Transform;
    public RectTransform button3Transform;
    void Update() {


        if(GlobalReader1.state == 1 && GlobalReader2.state == 1 && GlobalReader3.state == 1 || GlobalReader1.state == 1 && GlobalReader2.state == 1 && GlobalReader3.state == 0 || GlobalReader1.state == 1 && GlobalReader2.state == 0 && GlobalReader3.state == 1 || GlobalReader1.state == 1 && GlobalReader2.state == 0 && GlobalReader3.state == 0) {
            state = "Game 1";
        }
        if(GlobalReader1.state == 1 && GlobalReader2.state == 1 && GlobalReader3.state == 1 || GlobalReader1.state == 0 && GlobalReader2.state == 1 && GlobalReader3.state == 1 || GlobalReader1.state == 1 && GlobalReader2.state == 1 && GlobalReader3.state == 0 || GlobalReader1.state == 0 && GlobalReader2.state == 1 && GlobalReader3.state == 0) {
            state = "Information";
        }
        if(GlobalReader1.state == 1 && GlobalReader2.state == 1 && GlobalReader3.state == 1 || GlobalReader1.state == 0 && GlobalReader2.state == 1 && GlobalReader3.state == 1 || GlobalReader1.state == 1 && GlobalReader2.state == 0 && GlobalReader3.state == 1 || GlobalReader1.state == 0 && GlobalReader2.state == 0 && GlobalReader3.state == 1) {
            state = "menu";
        }
        if (state == "menu") {
            text1.SetActive(true);
            text3.SetActive(false);
            pollutantInfo.SetActive(false);
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(false);
            MenuController2.complete = false;
        } else if (state == "Game 1") {
            text1.SetActive(false);
            text3.SetActive(false);
            pollutantInfo.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(true);
            button3.SetActive(true);
        } else if (state == "Information") {
            text1.SetActive(false);
            text3.SetActive(true);
            pollutantInfo.SetActive(true);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(true);
            MenuController2.complete = false;
            button3Transform.anchoredPosition = new Vector2(position1[0], position1[1]);
        }
        GlobalReader1.state = 0;
        GlobalReader2.state = 0;
        GlobalReader3.state = 0;

    }

}
