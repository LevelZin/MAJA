using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PartyMemberScript : BaseUnit
{
    [SerializeField]
    UnityEngine.UI.Text[] actionButtons;
    int[] attackNumber;

    bool alive = true;

    void Awake()
    {
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

    public void PerformAttack(int attackNumber)
    {
        if (attackNumber == 0)
        {
            Debug.Log("Attacking");
            target.RecieveDamage(ability[0].damage);
            gameManager.AttackDone();
        }
        else if (attackNumber == 1)
        {
            target.RecieveDamage(ability[1].damage);
            Debug.Log("Casts skill");
        }
        else if (attackNumber == 2)
        {
            player.RecieveDamage(ability[2].damage);
            Debug.Log("Healing");
        }
        else if (attackNumber == 3)
        {
            target.RecieveDamage(ability[3].damage);
            Debug.Log("Wait");
        }
        else
        {
            StartCoroutine(StartDelayFlee(5));
            Debug.Log("Flee");
        }
    }

    public void OnClick()
    {

    }

    IEnumerator StartDelayFlee(float duration)
    {
        yield return new WaitForSeconds(duration);   //Wait
        //SceneManager.LoadScene(Enter index of main level here);
    }

}
