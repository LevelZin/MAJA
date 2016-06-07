using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class PartyMemberScript : BaseUnit
{
    [SerializeField]
    UnityEngine.UI.Text[] actionButtons;
    int[] attackNumber;

    [SerializeField]
    GameObject battleCanvas;

    [SerializeField]
    protected AudioClip swing;

    AudioSource audio;

    bool alive = true;

    void Awake()
    {
        Animator Maja = GetComponent<Animator>();
        for (int i = 0; i < actionButtons.Length; i++)
        {
            actionButtons[i].text = ability[i].attack_name;
        }

        if (m_HP == 0)
        {
            alive = false;
        }
        else
        {
            alive = true;
        }
    }

    void LateUpdate()
    {
        if (player.HP <= 0)
        {
            battleCanvas.GetComponent<Canvas>().enabled = false;
        }
    }

    public void PerformAttack(int attackNumber)
    {
        audio = GetComponent<AudioSource>();

        Animator Maja = GetComponent<Animator>();
        if (attackNumber == 0)
        {
            Debug.Log("Attacking");
            GetComponent<AudioSource>().PlayOneShot(swing, 0.6F);
            Maja.SetTrigger("Maja attack");
            target.RecieveDamage(ability[0].damage);
            gameManager.AttackDone();
        }
        else if (attackNumber == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(swing, 0.6F);
            target.RecieveDamage(ability[1].damage);
            player.SP -= 20;
            Debug.Log("Casts skill");
            gameManager.AttackDone();
        }
        else if (attackNumber == 2)
        {
            if (player.HP < 70)
            {
                player.SP -= 10;
                player.RecieveDamage(ability[2].damage);
                Debug.Log("Healing");
                gameManager.AttackDone();
            }
            else if (player.HP > 70 && player.HP < 100)
            {
                player.SP -= 10;
                player.HP = 100;
                Debug.Log("Healing");
                gameManager.AttackDone();
            }
            else
            {
                Debug.Log("Health already at maximum!");
                gameManager.AttackDone();
            }
        }
        else if (attackNumber == 3)
        {
            Debug.Log("Wait");
            gameManager.AttackDone();
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(scream, 0.6F);
            flee = true;
            battleCanvas.GetComponent<Canvas>().enabled = false;
            //gameManager.AttackDone();
            Debug.Log("Flee");
            StartCoroutine(StartDelayFlee(3.0f));
        }
    }
    
    IEnumerator StartDelayFlee(float duration)
    {
        yield return new WaitForSeconds(duration);   //Wait
        SceneManager.LoadScene(1);
    }

}
