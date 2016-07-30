using UnityEngine;
using System.Collections;

public class SmokeMedium1 : MonoBehaviour {

    Animator m_Anim;
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        player = GameObject.Find("KP");
        m_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float PlayerNear = Vector3.Distance(player.transform.position, transform.position);
        if (PlayerNear <= 2.0)
        {
            GameObject.Find("SmokeMedium1").GetComponent<SmokeMedium1>().m_Anim.SetBool("SmokeOn", true);
        }
        if (PlayerNear > 2.0)
        {
            GameObject.Find("SmokeMedium1").GetComponent<SmokeMedium1>().m_Anim.SetBool("SmokeOn", false);
        }
    }
}
