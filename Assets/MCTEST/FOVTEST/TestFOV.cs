using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFOV : MonoBehaviour
{
    public float viewRadius;
    [Range(0,360)]
    public float viewAngle;

    public LayerMask targetMask;
    public LayerMask obstacleMask;

    [HideInInspector]
    public List<Transform> visibleTargets = new List<Transform>();

    IEnumerator FindTargetsWithDelay(float delay)
    {
        while(true)
        {
            yield return new WaitForSeconds(delay);
            FindVisibleTargets();
        }
    }

    private void Start()
    {
        StartCoroutine("FindTargetsWithDelay", .2f);
    }


    void FindVisibleTargets()
    {
        visibleTargets.Clear();
        //ALL ENEMIES REQUIRE COLLIDERS FOR THIS TO WORK!!!!
        Collider2D[] targetsInViewRadius = Physics2D.OverlapCircleAll(transform.position, viewRadius, targetMask);
        //This Finds Enemies in the FOV Area- isnt visualized yet, but math wise its there
        for(int i = 0; i <targetsInViewRadius.Length; i++)
        {
            Transform target = targetsInViewRadius[i].transform;
            Vector2 dirToTarget = (target.position - transform.position).normalized;
            if(Vector2.Angle(transform.up, dirToTarget) < viewAngle /2)
            {
                float dstToTarget = Vector3.Distance(transform.position, target.position);
                if(!Physics2D.Raycast(transform.position, dirToTarget, dstToTarget, obstacleMask))
                {
                    visibleTargets.Add(target);
                }
            }
        }
    }

    public Vector2 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees -= transform.eulerAngles.z;
        }
        return new Vector2(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }



    
}
