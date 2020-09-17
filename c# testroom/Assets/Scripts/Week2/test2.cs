using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class test2 : MonoBehaviour
{
    float smoothing = 3.5f;
    public Animator anim;
    public bool moving;
    public int clicksTilDeath;
    NavMeshAgent agent;

    public Vector3 Target
    {
        get { return target; }
        set
        {
            target = value;

            StopCoroutine("Movement");
            StartCoroutine("Movement", target);
        }
    }

    private Vector3 target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    IEnumerator Movement(Vector3 target)
    {
        while(Vector3.Distance(transform.position, target) > 0.1f)
        {
            //transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);
            agent.SetDestination(target);
            anim.SetBool("Walk", true);
            moving = true;
            yield return null;
        }
        anim.SetBool("Walk", false);
        moving = false;

        clicksTilDeath--;

        if(clicksTilDeath <= 0)
        {
            anim.enabled = false;
            moving = true;
        }

        yield return new WaitForSeconds(3f);
        Debug.Log("hello");
    }
}
