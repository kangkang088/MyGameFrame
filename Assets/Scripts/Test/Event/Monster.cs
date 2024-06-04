using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //public string name = "123";
    void Start()
    {
        Dead();
    }
    void Dead() {
        Debug.Log("Monster has dead!!!");

        EventCenter.GetInstance().EventTrigger("MonsterDead",this);


        //GameObject.Find("Player").GetComponent<Player>().MonsterDeadDo(this);
        //GameObject.Find("Task").GetComponent<Task>().MonsterDeadDo(this);
        //GameObject.Find("Other").GetComponent<Other>().MonsterDeadDo(this);
    }
}
