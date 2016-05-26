using UnityEngine;
using System.Collections;






public class BaseUnit : MonoBehaviour
{
    int StatHP;
    int StatSP;
    int StatPow;
    int StatRes;
    int StatSpd;
    public static bool cReady = false;


    public virtual void tick()
    {
        initiative += StatSpd;

        if (initiative <= 1000)
        {
            cReady = true;
        }


    }

    [SerializeField]
    [Range(0, 10000)]
    protected int m_HP = StatHP;

    [SerializeField]
    private RectTransform healthbar;

    [SerializeField]
    [Range(-1000, 2000)]
    public int initiative = 0;



    [SerializeField]
    protected BaseUnit target;

    //Resistances and Weaknesses
    [SerializeField]
    [Range(-5, 5)]
    protected float SlashVulnerability = 1;

    [SerializeField]
    [Range(-5, 5)]
    protected float BashVulnerability = 1;

    [SerializeField]
    [Range(-5, 5)]
    protected float FireVulnerability = 1;

    [SerializeField]
    [Range(-5, 5)]
    protected float IceVulnerability = 1;

    [SerializeField]
    [Range(-5, 5)]
    protected float ThunderVulnerability = 1;

    [SerializeField]
    [Range(-5, 5)]
    protected float EarthVulnerability = 1;

    [SerializeField]
    [Range(-5, 5)]
    protected float ForceVulnerability = 1;

    [SerializeField]
    [Range(-5, 5)]
    protected float MysticVulnerability = 1;



    [SerializeField]
    protected GameManager gameManager;

    [System.Serializable]
    public class abilities
    {
        public string attack_name;
        public int damage;
    }

    [SerializeField]
    UnityEngine.UI.Text feedbackText;


    void Update()
    {
        healthbar.sizeDelta = new Vector2(m_HP * 4.9f, 30.0f);
    }

    public void RecieveDamage(int damage)
    {
        feedbackText.text += "\n The target took " + damage + " dmg";

        m_HP -= damage;

    }

    [SerializeField]
    protected abilities[] ability;



        combatMenu()
    {
        initiative -= 1000;
    }



        waitCommand()
    {
        initiative = 1000;
    }

}