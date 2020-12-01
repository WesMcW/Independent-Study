using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqTest : MonoBehaviour
{
    public LinqEnemy closest;
    private LinqEnemy[] allEnemies;

    private IOrderedEnumerable<LinqEnemy> enemiesByDistance;

    private void Awake()
    {
        allEnemies = FindObjectsOfType<LinqEnemy>();
    }

    private void OnEnable()
    {
        enemiesByDistance = 
            allEnemies
            .OrderBy(t => Vector3.Distance(transform.position, t.transform.position));
    }

    void Update()
    {
        //closest = FindNearestEnemy();
        closest = enemiesByDistance.FirstOrDefault();
    }

    private LinqEnemy FindNearestEnemy()
    {
        return allEnemies
            .OrderBy(t => Vector3.Distance(transform.position, t.transform.position))
            .FirstOrDefault();
    }
}
