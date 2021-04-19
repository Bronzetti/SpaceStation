using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent; //declaração da variável agent 

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>(); //utilização do NavMeshAgent pegando a variável agent
    }
}
