using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArch : MonoBehaviour
{
    public GameObject objectToMove;
    public GameObject particalEffect;
    public GameObject particalEffect2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("TriggerArch");
            particalEffect.SetActive(true);
            particalEffect2.SetActive(true);
        }
    }
}