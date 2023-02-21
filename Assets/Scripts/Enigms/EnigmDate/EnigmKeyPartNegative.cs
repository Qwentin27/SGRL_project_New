using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmKeyPartNegative : AbstractEnigmDateKeyPart{
    public override void Action(){
        keyPart--;
        base.Action();
    }
}
