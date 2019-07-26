using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent player;
    public GameObject target;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.SetDestination(target.GetComponent<Transform>().position);
    }
}
