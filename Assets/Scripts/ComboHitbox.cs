using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboHitbox : MonoBehaviour
{
    public GameObject ComboManager;
    public int myValue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ComboManager.GetComponent<TriggerRockPush>().ComboMetre(myValue);
        }
    }
}