using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 

public class DetectionNPC : MonoBehaviour
{
  [SerializeField] public Button talkbutton;
  [SerializeField] public RectTransform startPanelFormate;
  [SerializeField] public RectTransform startPanel;
  [SerializeField] public RectTransform finishPanel;
  [SerializeField] public RectTransform panelResult;
    void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log("rentréee");
      if (other.CompareTag("Player")) {
        talkbutton.gameObject.SetActive(true);
        talkbutton.interactable = true;

      }
    }

    void OnTriggerExit2D(Collider2D other)
    {
      if (other.CompareTag("Player")) {
        talkbutton.gameObject.SetActive(false);
        talkbutton.interactable = false;
      }
    }
      
    public void hidePanel(){
      startPanel.gameObject.SetActive(false);
      startPanelFormate.gameObject.SetActive(false);
      finishPanel.gameObject.SetActive(false);
      panelResult.gameObject.SetActive(false);
    }
} 
