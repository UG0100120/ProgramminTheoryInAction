using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : Human
{
    private void Start()
    {
        Info();
    }

    public override void Info()
    {
        Name = "Abdullah";
        Age = "16";
        string str = "I am " + Name + " of " + Age + " years";
    }
}
