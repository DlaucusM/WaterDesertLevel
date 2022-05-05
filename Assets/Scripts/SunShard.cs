using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunShard : MonoBehaviour
{
    public GameObject Me;
    public GameObject parent;
    public int myNumber;
    private bool moved = false;


    public void MoveShard()
    { 
        if (!moved)
        {
            Me.GetComponent<Animator>().SetTrigger("On");
            moved = true;
            parent.GetComponent<SunPuzzel>().Complete(myNumber, 1);
        }
        else if (moved)
        {
            Me.GetComponent<Animator>().SetTrigger("Off");
            moved = false;
            parent.GetComponent<SunPuzzel>().Complete(myNumber, 0);
        }      
    }
}
