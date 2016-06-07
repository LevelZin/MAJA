﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CombatTrigger : MonoBehaviour {

    public string[] Player;
    public int dialougeState;
    bool DisplayDialouge = false;
    bool Greetings = false;
    bool FinishedTalk = false;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(700, 500, 400, 400));  // Location of the GUI
        if (DisplayDialouge && dialougeState < Player.Length && !FinishedTalk)  // Talking with Morty
        {
            GUILayout.Label(Player[dialougeState]);
        }
        
        GUILayout.EndArea();

    }

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void OnTriggerEnter()
    {
        DisplayDialouge = true;
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5.0f);   //Wait
        SceneManager.LoadScene(3);
    }
}
