using UnityEngine;
using System.Collections;

public class CommonAxe : MonoBehaviour {

    public bool Active = false;
    public int damage = 15;
    public Animator m_Anim;
    Collider2D Colliders;
    public bool Block = false;
    float damageTimer;

    // Use this for initialization
    void Start()
    {
        Colliders.enabled = false;
        Active = false;
    }

    void Awake()
    {
        m_Anim = GetComponent<Animator>();
        Colliders = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (damageTimer > 0)
        {
            damageTimer -= Time.unscaledDeltaTime;
        }

        if (Active == true)
        {
            Colliders.enabled = true;
        }
        if (Active == false)
        {
            Colliders.enabled = false;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (Block == false)
        {
            if (col.gameObject.tag == "CornEnemy")
            {
                if (damageTimer <= 0)
                {
                    damageTimer = 1.0f;
                    col.gameObject.GetComponent<CornEnemy>().DamageEnemy(damage);
                }
            }
        }
    }
}
