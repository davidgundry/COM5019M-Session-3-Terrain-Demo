using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class AgentBehaviour : MonoBehaviour
{
    private NavMeshAgent _nma;

    // Start is called before the first frame update
    void Start()
    {
        _nma = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
                _nma.destination = hit.point;
        }
    }

    void OnTriggerEnter(Collider c)
    {
        Destroy(c.gameObject);
    }
}
