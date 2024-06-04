using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMusic : MonoBehaviour
{
    float v = 0;
    AudioSource source;
    private void OnGUI() {
        if(GUI.Button(new Rect(0,0,100,100),"播放音乐")) {
            v = 0;
            MusicMgr.GetInstance().ChangeBKMusicValue(v);
            MusicMgr.GetInstance().PlayBackMusic("Black");
        }
        if(GUI.Button(new Rect(100,100,100,100),"Pause")) {
            MusicMgr.GetInstance().PauseBackMusic();
        }
        if(GUI.Button(new Rect(200,200,100,100),"Stop")) {
            MusicMgr.GetInstance().StopBackMusic();
        }
        v += Time.deltaTime * 0.1f;
        if(v >= 1)
            v = 1;
        MusicMgr.GetInstance().ChangeBKMusicValue(v);
        if(GUI.Button(new Rect(300,200,100,100),"Sound")) {
            MusicMgr.GetInstance().PlaySound("Black",false,(s)=> 
            {
                source = s;   
            });
        }
        if(GUI.Button(new Rect(400,200,100,100),"Stop Sound")) {
            MusicMgr.GetInstance().StopSound(source);
            source = null;
        }
    }
}
