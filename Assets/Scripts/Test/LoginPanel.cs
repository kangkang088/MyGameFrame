using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginPanel : BasePanel {
    protected override void Awake() {
        //Must be exist!
        base.Awake();
        //...
    }
    // Start is called before the first frame update
    void Start() {
        //GetControl<Button>("ButtonStart").onClick.AddListener(ClickStart);
        //GetControl<Button>("ButtonQuit").onClick.AddListener(ClickQuit);

        UIMgr.GetInstance().AddCustomEventListener(GetControl<Button>("ButtonStart"),EventTriggerType.PointerEnter,(data) => {
            Debug.Log("Enter");
        });

        UIMgr.GetInstance().AddCustomEventListener(GetControl<Button>("ButtonStart"),EventTriggerType.PointerExit,(data) => {
            Debug.Log("Exit");
        });
    }
    protected override void OnClick(string controlName) {
        base.OnClick(controlName);
        switch(controlName) {
            case "ButtonStart":
                Debug.Log("Start");
                break;
            case "ButtonQuit":
                Debug.Log("Quit");
                break;
        }
    }
    protected override void OnValueChanged(string toggleName,bool value) {
        base.OnValueChanged(toggleName,value);
        //...

    }

    private void ClickQuit() {
        Debug.Log("Quit!!!");
    }

    private void ClickStart() {
        Debug.Log("Start!!!");
    }
    public void InitInfo() {
        Debug.Log("Initing");
    }

    // Update is called once per frame
    void Update() {

    }
}
