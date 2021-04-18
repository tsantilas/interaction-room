using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractKey : MonoBehaviour
{
    public Transform Player;
    public GameObject canvasInteract;

    public float maxDistance = 2.0f;
    RaycastHit hit;

    void Start()
    {
        canvasInteract.SetActive(false);
    }

    void Update()
    {

        if (Physics.Raycast(Player.transform.position, Player.transform.forward, out hit, maxDistance) && (hit.transform.tag == "Door" || hit.transform.tag == "Button"))
        {
            canvasInteract.SetActive(true);
        }
        else
        {
            canvasInteract.SetActive(false);
        }
    }
}
