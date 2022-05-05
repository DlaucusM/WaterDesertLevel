using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorHitBox : MonoBehaviour
{
    public GameObject myDoor1;
    public GameObject myDoor2;
    public GameObject myDoor3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           myDoor1.GetComponent<FinalDoor>().DoorTime();
           myDoor2.GetComponent<FinalDoor>().DoorTime();
           myDoor3.GetComponent<FinalDoor>().DoorTime();
        }
    }
} 