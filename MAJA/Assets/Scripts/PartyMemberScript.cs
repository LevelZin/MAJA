using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PartyMemberScript : BaseUnit
{
    [SerializeField]
    UnityEngine.UI.Text[] actionButtons;
    int[] attackNumber;

    [SerializeField]
    GameObject battleCanvas;

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
        

        Animator Maja = GetComponent<Animator>();
        if (attackNumber == 0)
        {
            Debug.Log("Attacking");
            Maja.SetTrigger("Maja attack");
            target.RecieveDamage(ability[0].damage);
            gameManager.AttackDone();
        }
        else if (attackNumber == 1)
        {
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
        SceneManager.LoadScene(0);
    }

}
