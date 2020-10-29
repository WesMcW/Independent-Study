using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWorld : MonoBehaviour
{
    public delegate void End();
    public static event End EndIt;

    public void EndTheWorld()
    {
        EndIt();
    }
}
