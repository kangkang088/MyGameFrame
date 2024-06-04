using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    private void Awake() {
        EventCenter.GetInstance().AddListener<Monster>("MonsterDead",TaskWaitMonsterDeadDo);
    }
    public void TaskWaitMonsterDeadDo(object obj) {
        Debug.Log("Monster has dead,the task has done! Monster Name:" + (obj as Monster).name);
    }
    private void OnDestroy() {
        EventCenter.GetInstance().RemoveListener<Monster>("MonsterDead",TaskWaitMonsterDeadDo);
    }
}
