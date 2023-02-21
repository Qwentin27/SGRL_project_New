using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractKeyPart : MonoBehaviour, IActionable{
    [SerializeField] protected int idKey, keyPart;
    protected AbstractSolution solution;

    void Start(){
        this.solution = GetComponentInParent<AbstractSolution>();
        if(this.solution == null){
            Debug.LogError("Solution script must be placed in the parent object!");
        }
    }

    protected void ActAsKey(){ // change current state
        solution.InsertKeyPart(this);
    }

    public int GetKeyPart(){
        return this.keyPart;
    }

    public void SetKeyPart(int newKeyPart){
        this.keyPart = newKeyPart;
    }

    public int GetIdKey(){
        return this.idKey;
    }

    public abstract void Action();
}
