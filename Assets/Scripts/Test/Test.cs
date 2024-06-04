using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTest {
    public void Test() {
        Debug.Log("Test");
    }
    public TestTest() {
        MonoMgr.GetInstance().StartCoroutineListener(Test1());
    }
    IEnumerator Test1() {
        yield return new WaitForSeconds(1f);
        Debug.Log("121212");
    }
}
public class Test : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        //NewBehaviourScript.GetInstance().Test();
        TestTest t = new TestTest();
        MonoMgr.GetInstance().AddUpdateListener(t.Test);

        UIMgr.GetInstance().ShowPanel<LoginPanel>("LoginPanel",E_UI_Layer.Mid,(panel)=> 
        {
            panel.InitInfo();
            //Invoke("DelayHide",1f);
        });
    }
    private void DelayHide() {
        UIMgr.GetInstance().HidePanel("LoginPanel");
    }


    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            PoolMgr.GetInstance().GetObj("Test/Cube",(o)=> { o.transform.localScale = Vector3.one * 10; });

            //GameObject obj = ResMgr.GetInstance().Load<GameObject>("Test/Cube");
            //obj.transform.localScale = Vector3.one * 2;
        }
        if(Input.GetMouseButtonDown(1)) {
            //PoolMgr.GetInstance().GetObj("Test/Sphere");

            ResMgr.GetInstance().LoadAsync<GameObject>("Test/Cube",(obj) => { obj.transform.localScale = Vector3.one * 10; });
        }
    }
    private void DoSomething(GameObject obj) {
        obj.transform.localScale = Vector3.one * 10;
    }
}
