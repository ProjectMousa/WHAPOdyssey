using UnityEngine;
using System.Collections;

public class ArmSwing : MonoBehaviour
{
    bool Swing = false;
    public Animator m_Anim;
    Collider2D Colliders;
    public float blockTimer;
    public bool Sword = false;
    public bool Axe = false;

    // Use this for initialization
    void Awake()
    {
        m_Anim = GetComponent<Animator>();
        Colliders = GetComponent<Collider2D>();
    }

    void Start()
    {
        Colliders.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (blockTimer > 0)
        {
            blockTimer -= Time.unscaledDeltaTime;
        }     
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {            
                    Swing = true;
                    m_Anim.SetBool("Swing", true);
                    Colliders.enabled = true;                            
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Swing = false;
            m_Anim.SetBool("Swing", false);
            Colliders.enabled = false;
            m_Anim.SetBool("Sword", false);
            m_Anim.SetBool("Axe", false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (GameObject.Find("KP").GetComponent<PlayerControl>().InventoryOpen == false) {
                if (GameObject.Find("KP").GetComponent<PlayerControl>().GameMenuOpen == false) {
                    if (GameObject.Find("KP").GetComponent<PlayerControl>().BuyMenuOpen == false)
                    {
                        if (blockTimer <= 0)
                        {
                            SwordBlock();                           
                        }
                    }
                }
            }                             
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            m_Anim.SetBool("Block", false);          
        }
    }
    void SwordBlock() {
        m_Anim.SetBool("Block", true);
    }
}