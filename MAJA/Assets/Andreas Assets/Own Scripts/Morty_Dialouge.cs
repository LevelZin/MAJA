using UnityEngine;
using System.Collections;

public class Morty_Dialouge : MonoBehaviour {

    public string[] Player;
    public string[] Morty;
    bool DisplayDialouge = false;
    bool Greetings = false;
    bool FinishedTalk = false;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(700, 600, 400, 400));  // Location of the GUI
        if (DisplayDialouge && !Greetings && !FinishedTalk)
        {
            GUILayout.Label(Morty[0]);
            if (GUILayout.Button(Player[0]))
            {
                Greetings = true;
                GUILayout.Label(Morty[1]);

                if (GUILayout.Button(Player[1]))
                {
                    GUILayout.Label(Morty[2]);

                    if (GUILayout.Button(Player[2]))
                    {
                        FinishedTalk = true;
                        GUILayout.Label(Morty[3]);

                        if (GUILayout.Button(Player[3]))
                        {
                            DisplayDialouge = false;
                        }
                    }
                }
            }
        }

        if (DisplayDialouge && Greetings && !FinishedTalk)
        {
            GUILayout.Label(Morty[1]);

            if (GUILayout.Button(Player[1]))
            {
                GUILayout.Label(Morty[2]);

                if (GUILayout.Button(Player[2]))
                {
                    FinishedTalk = true;
                    GUILayout.Label(Morty[3]);

                    if (GUILayout.Button(Player[3]))
                    {
                        DisplayDialouge = false;
                    }
                }
            }
        }

        if (DisplayDialouge && Greetings && FinishedTalk)
        {
            if (GUILayout.Button(Player[2]))
            {
                FinishedTalk = true;
                GUILayout.Label(Morty[3]);

                if (GUILayout.Button(Player[3]))
                {
                    DisplayDialouge = false;
                }
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
