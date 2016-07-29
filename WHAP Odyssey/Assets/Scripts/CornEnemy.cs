using UnityEngine;
using System.Collections;

public class CornEnemy : MonoBehaviour {
    public int CornEnemyHealth = 25;
    int CornEnemyMaxHealth = 25;    
    public GameObject player;
    Animator m_Anim;
    public float walkSpeed = 0.3f;      // Walkspeed
    public float wallLeft = 0.0f;       // Define wallLeft
    public float wallRight = 5.0f;      // Define wallRight
    float walkingDirection = 1.0f;
    Vector2 walkAmount;
    float originalX; // Original float value
    float damage = 10;
    public float damageTimer;
    int CoinDrop = 5;

    // Use this for initialization
    void Start() {
        this.originalX = this.transform.position.x;
        wallLeft = transform.position.x - 2.5f;
        wallRight = transform.position.x + 2.5f;
        GameObject.Find("CornEnemyHealth").GetComponent<EnemyHealthCanvas>().SetHealth(CornEnemyHealth, CornEnemyMaxHealth);
    }

    void Awake() {
        player = GameObject.Find("KP");
        m_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (damageTimer > 0)
        {
            damageTimer -= Time.unscaledDeltaTime;
        }

        if (damageTimer < 0) {
            damageTimer = 0;
        }

        walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
        if (walkingDirection > 0.0f && transform.position.x >= originalX + wallRight)
        {
            walkingDirection = -0.3f;
            Flip();
        }
        else if (walkingDirection < 0.0f && transform.position.x <= originalX - wallLeft)
        {
            walkingDirection = 0.3f;
            Flip();
        }
        transform.Translate(walkAmount);

        float PlayerDist = Vector3.Distance(player.transform.position, transform.position);
        if (PlayerDist >= 0.5) {
            m_Anim.SetBool("TouchingPlayer", false);
        }       
    }
    

    void OnCollisionEnter2D(Collision2D col)
    {      
        if (damageTimer <= 0) {
            if (col.gameObject == player)
            {
                damageTimer = 1;
                DamagePlayer();        
            }
        }       
    }

    public void DamageEnemy (int damage) {
        CornEnemyHealth = CornEnemyHealth - damage;
        if (CornEnemyHealth <= 0) {
            Destroy(gameObject);
            player.GetComponent<PlayerControl>().ChangeCoins(CoinDrop);
        }
        GameObject.Find("CornEnemyHealth").GetComponent<EnemyHealthCanvas>().SetHealth(CornEnemyHealth, CornEnemyMaxHealth);
    }
    void Flip() {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        Vector3 textScale = GameObject.Find("CornEnemyHealth").transform.localScale; //flips canvas
        textScale.x *= -1;
        GameObject.Find("CornEnemyHealth").transform.localScale = textScale;
    }
    public void DamagePlayer() {     
        GameObject.Find("KP").GetComponent<PlayerControl>().DamagePlayer(damage);
        m_Anim.SetBool("TouchingPlayer", true);
    }
}
