using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitControl : MonoBehaviour
{
    private Vector3 targetPosition;
    public float duration; //to calculate movement speed for unit
    private bool isRunning; //unit is running or staying?
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //NEED TO CHANGE THIS PART (убрать привязку к мыши; сделать привязку к поверхности (если жмешь на точку выше уровня поверхности, юнит "задирает нос" и бежит)
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray;
            RaycastHit hit; 
            ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if (Physics.Raycast(ray, out hit))
            {
                isRunning = true;
                targetPosition = hit.point; 
               
            }
        }

        if (isRunning && !Mathf.Approximately(transform.position.magnitude, targetPosition.magnitude))
        {
            transform.LookAt(targetPosition);
            transform.position = Vector3.Lerp(transform.position, targetPosition, 1 / (duration * Vector3.Distance(transform.position, targetPosition))); //Plavnoe peremeshenie
            CheckAnimation();
        }
        else if (isRunning && Mathf.Approximately(transform.position.magnitude, targetPosition.magnitude))
        {
            isRunning = false;
            CheckAnimation();
        }
        }
    //NEED TO CHANGE THIS PART
    private void CheckAnimation()
    {
        if (isRunning && anim.GetCurrentAnimatorStateInfo(0).IsName("WAIT00"))
        {
            anim.Play("RUN00_F");
        }
        else if (!isRunning && anim.GetCurrentAnimatorStateInfo(0).IsName("RUN00_F"))
        {
            anim.Play("WAIT00");
        }
    }
}

