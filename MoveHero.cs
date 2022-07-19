using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveHero : MonoBehaviour
{
    [Header("Set in Inspector")]
    public LayerMask whatCanBeClickedOn;

    private NavMeshAgent myAgent;

    public void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, 200, whatCanBeClickedOn))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
