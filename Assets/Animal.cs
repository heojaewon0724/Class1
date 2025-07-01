using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Animal
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string name;
    public string sound;

    // Update is called once per frame
   public void Playsound()
    {
        Debug.Log(name + " : " + sound);
    }
}
