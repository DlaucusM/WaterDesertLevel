using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPuzzel : MonoBehaviour
{
    public GameObject Sun1;
    public GameObject Sun2;
    public GameObject Sun3;
    public GameObject Sun4;
    public GameObject Sun5;
    public GameObject Sun6;
    public GameObject Sun7;
    public GameObject Sun8;
    public GameObject bars;
    private bool toggle;
    private List<int> list = new List<int> {0,0,0,0,0,0,0,0}; 

    public void Complete(int index,int moved)
    {
        list[index] = moved;
        toggle = true;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == 0)
            {
                toggle = false;
            } 
        }
        if (toggle)
        {
            bars.GetComponent<Animator>().SetTrigger("On");
        }
    }
    public void inputManager(int inputValue)
    {
        if (inputValue == 1)
        {
            Sun1.GetComponent<SunShard>().MoveShard();
            Sun8.GetComponent<SunShard>().MoveShard();
            Sun2.GetComponent<SunShard>().MoveShard();
        }
        if (inputValue == 2)
        {
            Sun1.GetComponent<SunShard>().MoveShard();
            Sun3.GetComponent<SunShard>().MoveShard();
            Sun2.GetComponent<SunShard>().MoveShard();
        }
        if (inputValue == 3)
        {
            Sun3.GetComponent<SunShard>().MoveShard();
            Sun4.GetComponent<SunShard>().MoveShard();
            Sun2.GetComponent<SunShard>().MoveShard();
        }
        if (inputValue == 4)
        {
            Sun5.GetComponent<SunShard>().MoveShard();
            Sun3.GetComponent<SunShard>().MoveShard();
            Sun4.GetComponent<SunShard>().MoveShard();
        }
        if (inputValue == 5)
        {
            Sun5.GetComponent<SunShard>().MoveShard();
            Sun6.GetComponent<SunShard>().MoveShard();
            Sun4.GetComponent<SunShard>().MoveShard();
        }
        if (inputValue == 6)
        {
            Sun5.GetComponent<SunShard>().MoveShard();
            Sun7.GetComponent<SunShard>().MoveShard();
            Sun6.GetComponent<SunShard>().MoveShard();
        }
        if (inputValue == 7)
        {
            Sun6.GetComponent<SunShard>().MoveShard();
            Sun8.GetComponent<SunShard>().MoveShard();
            Sun7.GetComponent<SunShard>().MoveShard();
        }
        if (inputValue == 8)
        {
            Sun1.GetComponent<SunShard>().MoveShard();
            Sun8.GetComponent<SunShard>().MoveShard();
            Sun7.GetComponent<SunShard>().MoveShard();
        }

    }
}
