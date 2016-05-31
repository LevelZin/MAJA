using UnityEngine;
using System.Collections;

public class PartyMemberScript : BaseUnit
{
    [SerializeField]
    UnityEngine.UI.Text[] actionButtons;

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
            target.RecieveDamage(ability[attackNumber].damage);
            gameManager.AttackDone();
        }
        else if(attackNumber == 1)
        {
            Debug.Log("Casts skill");
        }
        else if (attackNumber == 2)
        {
            Debug.Log("Healing");
        }
        else if (attackNumber == 3)
        {
            Debug.Log("Wait");
        }
        else
        {
            Debug.Log("Flee");
        }
    }

    public void OnClick()
    {

    }

    IEnumerator StartDelay(float duration)
    {
        yield return new WaitForSeconds(duration);   //Wait        
    }

}
