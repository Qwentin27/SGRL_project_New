using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmKeyPartPositive : AbstractEnigmDateKeyPart{
    public override void Action(){
        keyPart++;
        base.Action(); // i.e super de java
    }
}
