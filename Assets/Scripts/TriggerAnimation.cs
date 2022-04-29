using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public GameObject objectToMove;
    public bool insideSewers;


    // Start is called before the first frame update
    void Start()
    {
        insideSewers = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && insideSewers == false)
        {
            objectToMove.GetComponent<Animator>().SetTrigger("TriggerEntryAnimation");
            insideSewers = true;
            Debug.Log("entered");
        }
        else if (other.gameObject.tag == "Player" && insideSewers == true)
        {
            objectToMove.GetComponent<Animator>().SetTrigger("TriggerExitAnimation");
               insideSewers = false;
            Debug.Log("Exited");
        }
    }
}
