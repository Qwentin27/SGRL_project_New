using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReadingManager : MonoBehaviour{

    [SerializeField] GameObject TMP;
    [SerializeField] GameObject ImOnScreen;
    private RectTransform rectTr;
    private TextMeshProUGUI textmesh;
    private Image image;
    private int width, height;
    private bool isReading = false, isWatching = false, isHidingT = false, isHidingI = false, active = false;

    void Start(){
        textmesh = TMP.GetComponent<TextMeshProUGUI>();
        image = ImOnScreen.GetComponent<Image>();
        rectTr = ImOnScreen.GetComponent<RectTransform>();
        if(textmesh != null){
            textmesh.SetText("");
            textmesh.color = new Color(1 , 1 , 1 , 0);
        }
        if(image != null){
            image.color = new Color(1, 1, 1, 0);
        }
    }

    void Update(){ // note : c'est en deltaTime, pas en fixed, du coup attention aux FPS
        if(active){
            if(isReading){
                if(isHidingT)
                    isHidingT = false;
                textmesh.color += new Color(0,0,0, Time.deltaTime);
                if(textmesh.color.a >= 1){
                    active = false;
                    isReading = false;
                }
            }
            if(isWatching){
                if(isHidingI)
                    isHidingI = false;
                image.color += new Color(0,0,0, Time.deltaTime);
                if(image.color.a >= 1){
                    active = false;
                    isWatching = false;
                }
            }
            if(isHidingT){
                textmesh.color -= new Color(0,0,0, Time.deltaTime);
                if(textmesh.color.a <= 0){
                    active = false;
                    isHidingT = false;
                }
            }
            if(isHidingI){
                image.color -= new Color(0,0,0, Time.deltaTime);
                if(image.color.a <= 0){
                    active = false;
                    isHidingI = false;
                }
            }
        }
    }

    public void Read(string text){
        textmesh.SetText(text);

        active = true;
        isReading = true;
        isHidingT = false;
        isWatching = false;
    }

    public void HideRest(){
        active = true;
        isReading = false;
        isWatching = false;
    }

    public void HideImage(){
        isHidingI = true;
        HideRest();
    }

    public void HideText(){
        isHidingT = true;
        HideRest();
    }

    public void Watch(Sprite sp, int w, int h){
        this.image.sprite = sp;

        if(rectTr != null){
            rectTr.sizeDelta = new Vector2(w, h); // NB : le recteangle est en read only! donc, modifier via les ancres -> sizeDelta
        }        

        active = true;
        isReading = false;
        isHidingT = false;
        isWatching = true;
    }

}
