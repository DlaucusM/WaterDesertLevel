using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    private bool mode = true;   
    public void DoorTime()
    {
        if (mode)
        {
            GetComponent<Animator>().SetTrigger("Off");
            mode = false;
        }
        else if (!mode)
        {
            GetComponent<Animator>().SetTrigger("On");
            mode = true;
        }
    }
}
