using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWin : MonoBehaviour
{
    public GameObject Canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Canvas.SetActive(true);
        }
    }
}