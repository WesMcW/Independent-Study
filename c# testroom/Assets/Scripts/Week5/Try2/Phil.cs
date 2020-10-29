using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phil : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        EndWorld.EndIt += FreakOut;
    }

    public void FreakOut()
    {
        anim.SetTrigger("Freak");
    }
}
