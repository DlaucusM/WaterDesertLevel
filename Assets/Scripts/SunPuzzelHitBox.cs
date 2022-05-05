using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPuzzelHitBox : MonoBehaviour
{
    public GameObject PuzzelManager;
    public int myValue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PuzzelManager.GetComponent<SunPuzzel>().inputManager(myValue);
        }
    }
}
