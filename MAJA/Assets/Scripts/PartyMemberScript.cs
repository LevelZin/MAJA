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
            //actionButtons[i].text = ability[i].attack_name;
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
        Debug.Log("Attacking");
        target.RecieveDamage(ability[attackNumber].damage);
        gameManager.AttackDone();
    }

    IEnumerator StartDelay(float duration)
    {
        yield return new WaitForSeconds(duration);   //Wait        
    }

}
