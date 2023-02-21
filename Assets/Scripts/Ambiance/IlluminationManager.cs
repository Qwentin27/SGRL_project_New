using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlluminationManager : MonoBehaviour{
    [SerializeField] List<Light> lights;

    [SerializeField] static float glow_rythm = 1f;
    private static bool is_lit = false;
    public static float base_intensity = 10f;
    public static int ticks = 3;
    private static int tmp_ticks = 0; // nombre de fois qu'un élément brille (i.e 1 phase)
    private static float time_passed = 0f;

    private static float value_0, value_1;

    void Start(){
        foreach(Light light_compo in lights){
            light_compo.enabled = false;
        }

    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Illumination();
        }
        if(is_lit){
            time_passed += Time.deltaTime;
            
            value_1 = Mathf.Sin(time_passed * glow_rythm );

            if(value_1 > 0 && value_0 < 0 || value_1 < 0 && value_0 > 0){ // si phase suivante
                tmp_ticks++;
            }
            
            if(tmp_ticks == ticks){
                StopGlow();
            }
            value_0 = value_1;
        }
        
    }

    public void FixedUpdate(){
        if(is_lit)
            foreach(Light light_compo in lights)
                light_compo.intensity = base_intensity * Mathf.Abs( value_1 );
    }

    private void Illumination(){
        if(!is_lit){ // inutile de recommencer la phase si c'est déjà actif
            time_passed = 0f;
            is_lit = true;
            foreach(Light light_compo in lights)
                light_compo.enabled = true;
        }
        tmp_ticks = 0;
    }

    private void StopGlow(){
        is_lit = false;
        foreach(Light light_compo in lights)
            light_compo.enabled = false;
        value_1 = 0;
        tmp_ticks = 0;
    }

}
