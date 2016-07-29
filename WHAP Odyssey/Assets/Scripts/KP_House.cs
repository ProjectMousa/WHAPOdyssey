using UnityEngine;
using System.Collections;

public class KP_House : MonoBehaviour {

    public Animator m_Anim;

    // Use this for initialization
    void Start () {
        m_Anim.SetBool("DoorOpen", false);
    }

    void Awake() {
        m_Anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "KP")
        {
            m_Anim.SetBool("PlayerInside", true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "KP")
        {
            m_Anim.SetBool("PlayerInside", false);
        }
    }
}
