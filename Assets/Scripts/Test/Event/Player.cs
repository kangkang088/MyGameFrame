using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Awake() {
        EventCenter.GetInstance().AddListener<Monster>("MonsterDead",PlayerWaitMonsterDeadDo);
    }
    public void PlayerWaitMonsterDeadDo(object obj) {
        Debug.Log("Monster has dead,the player has gotten reward! Monster Name:" + (obj as Monster).name);
    }
    private void OnDestroy() {
        EventCenter.GetInstance().RemoveListener<Monster>("MonsterDead",PlayerWaitMonsterDeadDo);
    }
}
