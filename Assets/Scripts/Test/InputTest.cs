using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        InputMgr.GetInstance().StartOrEndCheck(true);
        EventCenter.GetInstance().AddListener<KeyCode>("Key_Down",(key) => {
            switch(key) {
                case KeyCode.W:
                    Debug.Log("forward");
                    break;
                case KeyCode.A:
                    Debug.Log("left");
                    break;
                case KeyCode.D:
                    Debug.Log("right");
                    break;
                case KeyCode.S:
                    Debug.Log("back");
                    break;
            }
        });
        EventCenter.GetInstance().AddListener<KeyCode>("Key_Up",(key) => 
        {
            switch(key) {
                case KeyCode.W:
                    Debug.Log("stop forward");
                    break;
                case KeyCode.A:
                    Debug.Log("stop left");
                    break;
                case KeyCode.D:
                    Debug.Log("stop right");
                    break;
                case KeyCode.S:
                    Debug.Log("stop back");
                    break;
            }
        });
    }
}
