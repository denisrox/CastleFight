using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResControl : MonoBehaviour
{
    public Text resourseText;

    public int wood;
    public int stone;
    public int iron;
    public int gold;
    public int food;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateResources();
    }

    private void UpdateResources()
    {
        //resourseText.text = "Дерево: " + wood + "  Камень: " + stone + " Железо: " + iron + " Золото: " + gold + " Еда: " + food;

    }
}
