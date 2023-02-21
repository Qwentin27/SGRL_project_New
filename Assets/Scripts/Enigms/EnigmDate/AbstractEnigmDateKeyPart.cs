using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnigmDateKeyPart : AbstractKeyPart{
    [SerializeField] AbstractEnigmDateKeyPart pair;
    [SerializeField] int borne;
    [SerializeField] MeshRenderer number_panel_renderer_1, number_panel_renderer_2;

    public override void Action(){
        keyPart = Mathf.Clamp(keyPart, 0, borne);
        pair.SetKeyPart(keyPart); // éviter d'avoir un bouton à 20 et l'autre à 5
        ActAsKey();
        Debug.Log(this.name+" is in state : "+keyPart);
        number_panel_renderer_1.material = ((EnigmDate)solution).GetMaterial( (int)Mathf.Floor(keyPart/10) ); // le cast, c'est la vie
        number_panel_renderer_2.material = ((EnigmDate)solution).GetMaterial( keyPart%10 ); // division et modulo pour la décennie et l'année
    }
}
