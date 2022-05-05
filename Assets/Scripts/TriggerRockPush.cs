using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRockPush : MonoBehaviour
{
    public GameObject objectToMove;
    public GameObject particalEffect;
    public GameObject particalEffect2;
    private List<int> combo = new List<int> { 5, 3, 2, 4, 1 };
    private List<int> currentCombo = new List<int> {};
    private bool pass;

    public void ComboMetre(int importValue)
    {
        currentCombo.Add(importValue);
        Debug.Log(currentCombo.Count);
        if (currentCombo.Count > 4)
        {

            pass = true;
            for (int i = 0; i < 5; i++)
            {
                if (currentCombo[currentCombo.Count-5+i] != combo[i])
                {
                   pass = false;
                    Debug.Log(currentCombo[currentCombo.Count-i-1]);

                }
               /* Debug.Log(currentCombo[0]);
                Debug.Log(currentCombo[1]);
                Debug.Log(currentCombo[2]);
                Debug.Log(currentCombo[3]);
                Debug.Log(currentCombo[4]);
               */
            }
            if (pass == true)
            {
                objectToMove.GetComponent<Animator>().SetTrigger("RockPush");
                particalEffect.SetActive(true);
                particalEffect2.SetActive(true);
            }
        }
    }
}