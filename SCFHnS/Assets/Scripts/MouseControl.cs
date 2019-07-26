using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    public GameObject mouseTarget;
    public Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SelectObject();
        }
        if (mouseTarget != null)
        {
            mousePosition = mouseTarget.GetComponent<Transform>().position;
        }
    }

    void SelectObject()
    {
        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            mouseTarget = hit.collider.gameObject;
        }
    }

}
