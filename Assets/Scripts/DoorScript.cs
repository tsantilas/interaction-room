using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Transform Player;
    public float maxDistance = 2.0f;

    public bool isOpen;
    private Animator anim;
    RaycastHit hit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Door();
        }
    }

    void Door()
    {

        if (Physics.Raycast(Player.transform.position, Player.transform.forward, out hit, maxDistance) && hit.transform.tag == "Door")
        {
            anim = hit.transform.GetComponent<Animator>();
            anim.SetBool("isOpen", !isOpen);
            isOpen = !isOpen;
        }
    }
}