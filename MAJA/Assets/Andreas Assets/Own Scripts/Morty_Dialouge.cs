using UnityEngine;
using System.Collections;

public class Morty_Dialouge : MonoBehaviour {

    public string[] Player;
    public string[] Morty;
    bool DisplayDialouge = false;
    bool FinishedTalk = false;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(700, 600, 400, 400));

    }

    void OnTriggerEnter()   // When Player enters the trigger
    {

    }

    void OnTriggerExit()    // When Player leaves the trigger
    {

    }
	
}
