using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : SingletonAutoMono<NewBehaviourScript> {
    private void Start() {
        
    }
    public void Test() {
        Debug.Log(GetInstance().name);
    }
}
