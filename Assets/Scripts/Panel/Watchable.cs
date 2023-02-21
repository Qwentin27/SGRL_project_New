using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watchable : MonoBehaviour, Displayable{
    [SerializeField] int width, height;
    [SerializeField] Sprite sprite;
    [SerializeField] GameObject panel_manager;
    private ReadingManager readingmanager;

    void Start(){
        readingmanager = panel_manager.GetComponent<ReadingManager>();
    }

    public void Display(){
        readingmanager.Watch(sprite, width, height);
    }

    public void Hide(){
        readingmanager.HideImage();
    }
}
