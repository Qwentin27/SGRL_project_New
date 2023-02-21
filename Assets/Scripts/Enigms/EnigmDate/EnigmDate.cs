using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmDate : AbstractSolution{
    [SerializeField] GameObject reward;
    [SerializeField] List<Material> materials; // à déplacer, probablement

    public override void Action(){
        if(CheckSolution()){
            if(reward != null)
                reward.SetActive(true);
        }
    }

    public Material GetMaterial(int index){
        return materials[index];
    }

}
