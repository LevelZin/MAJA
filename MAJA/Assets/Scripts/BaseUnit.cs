using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BaseUnit : MonoBehaviour
{
    //Stats
    [SerializeField]
    [Range(0, 9999)]
    protected int StatHP;

    [SerializeField]
    [Range(0, 9999)]
    protected int StatSP;

    [SerializeField]
    [Range(0, 999)]
    protected int StatPow;

    [SerializeField]
    [Range(0, 999)]
    protected int StatRes;

    [SerializeField]
    [Range(0, 999)]
    protected int StatSpd;

    //Added by Maria
    [SerializeField]
    protected GameObject Enemy;

    [SerializeField]
    protected GameObject Player;

    [SerializeField]
    protected BaseUnit player;

    [SerializeField]
    protected BaseUnit enemy;

    public bool flee = false;

    public static bool cReady = false;

    [SerializeField]
    protected float duration;

    public virtual void tick()
    {
        initiative += StatSpd;

        if (initiative <= 1000)
        {
            cReady = true;
        }


    }
    
    
    [SerializeField]
    [Range(0, 100)]
    protected int m_HP;
    public int HP
    {
        get { return m_HP; }
        set { m_HP = Mathf.Clamp(value, 0, StatHP); }
    }

    [SerializeField]
    [Range(0, 9999)]
    protected int m_SP;
    public int SP
    {
        get { return m_SP; }
        set { m_SP = Mathf.Clamp(value, 0, StatSP); }
    }



    [SerializeField]
    private RectTransform healthbar;

    //Added by Maria
    [SerializeField]
    private RectTransform spellbar;

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

    void Start()
    {
        m_HP = StatHP;
        m_SP = StatSP;
    }

    void Update()
    {
        healthbar.sizeDelta = new Vector2(m_HP * 6.54f, 32.0f);
        //Added by Maria
        spellbar.sizeDelta = new Vector2(m_SP * 4.86f, 24.0f);

        ////Added by Maria
        //if (enemy.HP <= 0)
        //{
        //    EnemyDie();
        //}
    }

    public void RecieveDamage(int damage)
    {
        //feedbackText.text += "\n The target took " + damage + " dmg";
        Debug.Log("The target took: " + damage + " damage");
        m_HP -= damage;
        Debug.Log("Target has: " + m_HP + " HP");

    }

    [SerializeField]
    protected abilities[] ability;

    public void combatMenu()
    {
        initiative -= 1000;
        return;
    }

    public void waitCommand()
    {
        initiative = 1000+StatSpd;
        return;
    }

    //Added by Maria
    public void EnemyDie()
    {
        Debug.Log("Enemy died.");
        GameObject.Destroy(Enemy);
        StartCoroutine(StartDelayEnemy(duration));
    }

    public void PlayerDie()
    {
        
        player.HP = 0;
        player.m_HP = 0;
        player.StatHP = 0;
        Debug.Log("Player died.");

        StartCoroutine(StartDelayMaja(3));
        
    }

    IEnumerator StartDelayMaja(float duration)
    {
        Animator Maja = GetComponent<Animator>();
        Maja.SetTrigger("Maja death");

        yield return new WaitForSeconds(duration);   //Wait
        
        GameObject.Destroy(Player);
        SceneManager.LoadScene(0);        
    }

    IEnumerator StartDelayEnemy(float duration)
    {
        //Enemy die animations here!

        yield return new WaitForSeconds(duration);   //Wait

        GameObject.Destroy(Enemy);
        SceneManager.LoadScene(0);
    }

}