using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steve : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        EndWorld.EndIt += PeeSelf;
    }

    public void PeeSelf()
    {
        anim.SetTrigger("Pee");  
    }
}
