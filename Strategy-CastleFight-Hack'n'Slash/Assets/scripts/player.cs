using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class player : MonoBehaviour
{

    public GameObject target;
    public Vector3 mouse_posit;

    void Start()
    {

    }

    void Update()
    {
        if (target != null)
        {
            RaycastHit[] hit;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            hit=Physics.RaycastAll(ray, 100);
            for (int i = 0;i<hit.Length;i++) 
            {
                if (hit[i].collider.gameObject.name == "Terrain")
                    mouse_posit = hit[i].point;
            }
        }

        if (Input.GetMouseButtonUp(1))
        {
            PKM();
        }
        if (Input.GetMouseButtonUp(0))
        {
            LKM();
        }

    }
    void LKM()
    {
        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) 
        {
            if (isGameObject())
            {
                target = hit.collider.gameObject;
            }
        }
    }
    Boolean isGameObject()
    {
        return true;
    }
    void PKM()
    {
        if (target != null) { 
        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            //if (hit.collider.gameObject.tag == "terrain") //если тыкнули на землю
            //{
            //    target.GetComponent<infob>().xyz = hit.point; //передать
            //    target.GetComponent<infob>().target = null;
            //    if (target.GetComponent<inf_player>() != null) // НУЖНО СУКА ИЗБАВИТЬСЯ ОТ ЭТОЙ ПРОВЕРКИ! Сам INF_PLAYER должен ЗАСТАВЛЯТЬ ЛЕНИВОГО ЮНИТА ДВИГАТЬСЯ И МЕНЯТЬ АНИМАЦИЮ
            //    {
            //        target.GetComponent<inf_player>().wait = false; //передать чтобы эта педрила перестала стоять на месте
            //        target.GetComponent<inf_player>().main.SetDestination(hit.point); //передать чуваку что ему пора бы начать пиздовать
            //        target.GetComponent<inf_player>().main.isStopped = false;
            //        target.GetComponent<inf_player>().anim.SetInteger("sost", 1);
            //    } //передать чтобы он сменил анимацию
            //    //target.GetComponent<inf_player>().wait = true;
            //}
            //if (hit.collider.gameObject.tag == "castle" || hit.collider.gameObject.tag == "player") //если тыкнули на игрока
            //{
            //    target.GetComponent<infob>().target = hit.collider.gameObject;
            //    if (target.GetComponent<inf_player>() != null)// НУЖНО СУКА ИЗБАВИТЬСЯ ОТ ЭТОЙ ПРОВЕРКИ! Сам INF_PLAYER должен ЗАСТАВЛЯТЬ ЛЕНИВОГО ЮНИТА ДВИГАТЬСЯ И МЕНЯТЬ АНИМАЦИю
            //    {
            //    target.GetComponent<inf_player>().wait = false; //передать чтобы эта педрила перестала стоять на месте
            //    target.GetComponent<inf_player>().anim.SetInteger("sost", 1); //передать чтобы онсменил анимацию
            //    target.GetComponent<inf_player>().main.isStopped = false;
            //    }
            //}
        }
        }
    }
    
}
