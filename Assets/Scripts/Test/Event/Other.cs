using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    private void Awake() {
        EventCenter.GetInstance().AddListener<Monster>("MonsterDead",OtherWaitMonsterDeadDo);
    }
    public void OtherWaitMonsterDeadDo(object obj) {
        Debug.Log("Monster has dead,the other has gotten reward! Monster Name:" + (obj as Monster).name);
    }
    private void OnDestroy() {
        EventCenter.GetInstance().RemoveListener<Monster>("MonsterDead",OtherWaitMonsterDeadDo);
    }
}
