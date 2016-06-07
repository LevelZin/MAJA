using UnityEngine;
using System.Collections;

public class Morty_Dialouge : MonoBehaviour {

    public string[] Player;
    public string[] Morty;
    public int dialougeState;
    bool DisplayDialouge = false;
    bool Greetings = false;
    bool FinishedTalk = false;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(600, 400, 300, 300));  // Location of the GUI
        if (DisplayDialouge && dialougeState < Player.Length && !FinishedTalk)  // Talking with Morty
        {
            GUILayout.Label(Morty[dialougeState]);
            if (GUILayout.Button(Player[dialougeState]))
            {
                //Greetings = true;
                dialougeState++;
                if (dialougeState >= Player.Length) // Dialouge can't move past leanght of Player Dialouge
                {
                    FinishedTalk = true;
                    DisplayDialouge = false;
                }
            }
        }
        if (DisplayDialouge && FinishedTalk)    // After you have finished talking with Morty
        {
            GUILayout.Label(Morty[3]);
            if (GUILayout.Button(Player[3]))
            {
                DisplayDialouge = false;
            }
        }



            GUILayout.EndArea();

    }

    void OnTriggerEnter()   // When Player enters the trigger
    {
        DisplayDialouge = true;
    }

    void OnTriggerExit()    // When Player leaves the trigger
    {
        DisplayDialouge = false;
    }
	
}
