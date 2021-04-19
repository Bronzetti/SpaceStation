using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents; //criação de uma variável para o objeto 

    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai"); //Pega os objetos através da TAG
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; //o personagem se movimentará até a posição do mouse aonde foi clicado, movendo-se do ponto de origem até esse ponto final 
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) //pega input do mouse e a movimentação do mouse, com o raycast, respeitando colisões evitando grandes bugs
            {
                foreach (GameObject a in agents) //manter sempre a repetição para movimentação
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point); //AIControl com GetComponent para o agent
            }
        }
    }
}
