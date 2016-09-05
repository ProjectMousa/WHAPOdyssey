using UnityEngine;
using System.Collections;

public class BlooScript : MonoBehaviour {
    public Animator m_Anim;
    public float sitTimer;
    public bool Idle = true;
    public bool Sit = false;
    public bool Sitting = false;
    public float sittingTimer;

	// Use this for initialization
	void Awake() {
        m_Anim = GameObject.Find("Bloo").GetComponent<Animator>();
    }

    void Start () {
        m_Anim.ResetTrigger("Walking");
        m_Anim.ResetTrigger("Sitting");
        m_Anim.ResetTrigger("Sit");
        m_Anim.SetTrigger("Idle");

        sitTimer = 10;
        sittingTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (sitTimer > 0)
        {
            sitTimer -= Time.unscaledDeltaTime;
        }

        if (sitTimer < 0)
        {
            sitTimer = 0;
        }

        if (sitTimer == 0) {
            if (Sit == false) {
                SitDown();
            }       
        }

        if (sittingTimer > 0)
        {
            sittingTimer -= Time.unscaledDeltaTime;
        }

        if (sittingTimer < 0)
        {
            sittingTimer = 0;
        }

        if (sittingTimer == 0) {
            if (Sit == true) {
                if (Sitting == false)
                {
                    Sitting = true;
                    m_Anim.ResetTrigger("Walking");
                    m_Anim.ResetTrigger("Idle");
                    m_Anim.ResetTrigger("Sit");
                    m_Anim.SetTrigger("Sitting");
                }
            }
        }
    }
    void SitDown() {
        sittingTimer = 0.60f;
        m_Anim.ResetTrigger("Walking");
        m_Anim.ResetTrigger("Sitting");       
        m_Anim.ResetTrigger("Idle");
        m_Anim.SetTrigger("Sit");
        Idle = false;
        Sit = true;
    }
}
