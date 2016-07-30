using UnityEngine;
using System.Collections;

public class KP_HouseDoorCollider : MonoBehaviour {

    public GameObject player;
    Collider2D Colliders;
    public bool DoorOpen;

    // Use this for initialization
    void Start () {
        DoorOpen = false;
        player = GameObject.Find("KP");
        Colliders.enabled = true;
        GameObject.Find("KP_HouseOutside").GetComponent<KP_House>().m_Anim.SetBool("DoorOpen", false);     
    }
    void Awake() {
        Colliders = GetComponent<Collider2D>();
    }    

    // Update is called once per frame
    void Update () {
    float PlayerNear = Vector3.Distance(player.transform.position, transform.position);
      if (Input.GetKeyDown(KeyCode.E)) {           
        if (PlayerNear <= 0.2) {
                if (DoorOpen == true)
                {
                    GameObject.Find("KP_HouseOutside").GetComponent<KP_House>().m_Anim.SetBool("DoorOpen", false);
                    Colliders.enabled = true;
                    DoorOpen = false;
                }
                else if (DoorOpen == false) {
                    GameObject.Find("KP_HouseOutside").GetComponent<KP_House>().m_Anim.SetBool("DoorOpen", true);
                    Colliders.enabled = false;
                    DoorOpen = true;
                }       
            }
     }
   }   
}
