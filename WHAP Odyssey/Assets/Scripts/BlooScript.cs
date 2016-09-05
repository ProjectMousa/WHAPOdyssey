using UnityEngine;
using System.Collections;

public class BlooScript : MonoBehaviour {
    public Animator m_Anim;
    public float sitTimer;
    public bool Idle = true;
    public bool Sit = false;
    public bool Sitting = false;
    public float sittingTimer;
    public bool FollowPlayer = true;
    public float XPosCheck;
    public float moveCheck;
    public bool Moved = false;
    public float standingTimer;
    public bool Walking = false;
    public float PlayerDistance;

	// Use this for initialization
	void Awake() {
        m_Anim = GameObject.Find("Bloo").GetComponent<Animator>();
        XPosCheck = this.transform.position.x;
    }

    void Start () {
        m_Anim.ResetTrigger("Walking");
        m_Anim.ResetTrigger("Sitting");
        m_Anim.ResetTrigger("Sit");
        m_Anim.ResetTrigger("Stand");
        m_Anim.SetTrigger("Idle");

        sitTimer = 10;
        sittingTimer = 0;
        moveCheck = 0.01f;
        standingTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDistance = Vector3.Distance(GameObject.Find("KP").transform.position, this.transform.position);
        if (FollowPlayer == true)
        {
            if (PlayerDistance >= 0.425f)
            {
                this.transform.position = new Vector3(GameObject.Find("KP").transform.position.x - 0.425f, this.transform.position.y, this.transform.position.z);
            }
        }

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
                    m_Anim.ResetTrigger("Stand");
                    m_Anim.SetTrigger("Sitting");
                }
            }
        }

        if (moveCheck > 0)
        {
            moveCheck -= Time.unscaledDeltaTime;
        }

        if (moveCheck < 0)
        {
            moveCheck = 0;
        }

        if (standingTimer > 0)
        {
            standingTimer -= Time.unscaledDeltaTime;
        }

        if (standingTimer < 0)
        {
            standingTimer = 0;
        }

        if (moveCheck == 0) {
            if (XPosCheck == this.transform.position.x) {
                Moved = false;
                XPosCheck = this.transform.position.x;
                moveCheck = 0.01f;
                if (Sitting == false) {
                    if (Sit == false) {
                        if (standingTimer == 0)
                        {
                            if (Idle == false) {
                                m_Anim.ResetTrigger("Walking");
                                m_Anim.ResetTrigger("Sitting");
                                m_Anim.ResetTrigger("Sit");
                                m_Anim.ResetTrigger("Stand");
                                m_Anim.SetTrigger("Idle");
                                Idle = true;
                                Sit = false;
                                Sitting = false;
                                Walking = false;
                            }
                        }
                    }
                }
            }
            if (XPosCheck != this.transform.position.x) {
                if (XPosCheck - this.transform.position.x > 0) {
                    this.transform.localScale = new Vector3 (1, this.transform.localScale.y, this.transform.localScale.z);
                }

                if (XPosCheck - this.transform.position.x < 0)
                {
                    this.transform.localScale = new Vector3(-1, this.transform.localScale.y, this.transform.localScale.z);
                }

                Moved = true;
                XPosCheck = this.transform.position.x;
                moveCheck = 0.01f;
                sitTimer = 10;
                if (Sitting == true) {
                    StandUp();
                }
                if (Sitting == false)
                {
                    if (standingTimer == 0) {
                        if (Walking == false) {
                            m_Anim.ResetTrigger("Sitting");
                            m_Anim.ResetTrigger("Sit");
                            m_Anim.ResetTrigger("Stand");
                            m_Anim.ResetTrigger("Idle");
                            m_Anim.SetTrigger("Walking");
                            Walking = true;
                            Idle = false;
                            Sit = false;
                            Sitting = false;
                        }
                    }
                }
            }
        }
    }
    void SitDown() {
        sittingTimer = 0.60f;
        m_Anim.ResetTrigger("Walking");
        m_Anim.ResetTrigger("Sitting");       
        m_Anim.ResetTrigger("Idle");
        m_Anim.ResetTrigger("Stand");
        m_Anim.SetTrigger("Sit");
        Idle = false;
        Sit = true;
        Sitting = false;
    }

    void StandUp() {
        m_Anim.ResetTrigger("Walking");
        m_Anim.ResetTrigger("Sitting");       
        m_Anim.ResetTrigger("Sit");
        m_Anim.ResetTrigger("Idle");
        m_Anim.SetTrigger("Stand");
        Idle = true;
        Sit = false;
        Sitting = false;
        standingTimer = 0.60f;
    }
}
