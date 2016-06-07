using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class CombatTrigger : MonoBehaviour {

    public string[] Player;
    public int dialougeState;
    bool DisplayDialouge = false;
    bool Greetings = false;
    bool FinishedTalk = false;

    [SerializeField]
    protected AudioClip mjau;
    AudioSource audio;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(600, 400, 300, 300));  // Location of the GUI
        if (DisplayDialouge && dialougeState < Player.Length && !FinishedTalk)  // Talking with Morty
        {
            GUILayout.Label(Player[dialougeState]);
        }
        
        GUILayout.EndArea();

    }

    // Use this for initialization
    void Start ()
    {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void OnTriggerEnter()
    {
        audio.PlayOneShot(mjau, 0.1F);
        DisplayDialouge = true;
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5.0f);   //Wait
        SceneManager.LoadScene(2);
    }
}
