using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExamples : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        // rend.material.color = ColorUtilites.GetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)) ChangeColor();
    }

    public void ChangeColor()
    {
        rend.material.color = ColorUtilites.GetRandomColor();
        print("change " + rend.material.color.r);
    }
}
