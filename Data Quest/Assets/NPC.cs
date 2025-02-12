using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NPC : DetectionNPC
{

    public Boolean isStarting = true;


    public void interact() {
        if(isStarting){
            System.Random rnd = new System.Random();
            int randomNum = rnd.Next(2);
            if(randomNum==0){
                startPanel.gameObject.SetActive(true);
            }
            else{
                startPanelFormate.gameObject.SetActive(true);
            }  
        }
        else{
            finishPanel.gameObject.SetActive(true);
            panelResult.gameObject.SetActive(true);
        }

        isStarting = !isStarting;
    }
    public void isfalse(){
        isStarting=false;
    }
}
