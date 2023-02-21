using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Readable: MonoBehaviour, Displayable{
    [SerializeField] string text;
    [SerializeField] GameObject panel_manager;
    private ReadingManager readingmanager;
    void Start(){
        readingmanager = panel_manager.GetComponent<ReadingManager>();
    }

    public void Display(){
        readingmanager.Read(this.text);
    }

    public void Hide(){
        readingmanager.HideText();
    }
}
