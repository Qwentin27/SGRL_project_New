using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSolution : MonoBehaviour, IActionable{
    [SerializeField] protected List<int> solution = new List<int>();
    private List<int> currentKey = new List<int>();
    // note : et si HashMap?  <String (name game object) : Integer (state)> ->  à creuser 

    // Start is called before the first frame update
    void Start(){
        foreach(int i in solution){
            currentKey.Add(0); // Capacity?
        }
    }

    public void InsertKeyPart(AbstractKeyPart keypart){ // changer l'état temporaire de la solution selon la keypart passée
        currentKey[keypart.GetIdKey()] = keypart.GetKeyPart();
    }

    public bool CheckSolution(){ // return currentKey == solution ?
        bool check = true;
        int k = 0;

        do{
            check &= solution[k] == currentKey[k];
            k++;
        }
        while(check && k < solution.Count);

        return check;
    }

    public abstract void Action();
}
