using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Zoo : MonoBehaviour
{
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "냐옹";

        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "찍찍";

        jerry = tom;
        jerry.name = "미키";


        tom.Playsound();
        jerry.Playsound();
    }
}
