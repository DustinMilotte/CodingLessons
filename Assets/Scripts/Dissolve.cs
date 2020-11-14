using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    public float dissolveAmount = 1f;
    [Range(0f,1f)]
    public float dissolveSpeed;

    private Renderer[] rends;
    private List<Material> mats = new List<Material>();
    private bool isShownCompletely;


    private void Awake()
    {
        rends = GetComponentsInChildren<Renderer>();

        foreach (var rend in rends)
        {
            mats.Add(rend.material);
        }
    }

    private void Start()
    {
        foreach (var mat in mats)
        {
            mat.SetFloat("_DissolveAmount", dissolveAmount);
        }
    }

    private void Update()
    {
        if (dissolveAmount > 0f)
        {
            foreach (var mat in mats)
            {
                mat.SetFloat("_DissolveAmount", dissolveAmount);
            }
            dissolveAmount -= Time.deltaTime * dissolveSpeed;
        }
        else
        {
            foreach (var mat in mats)
            {
                mat.SetFloat("_DissolveAmount", 0f);
            }
        }
    }

    // private void Awake()
    // {
    //     rend = GetComponentInChildren<Renderer>();
    //     mat = rend.material;
    // }
    //
    // // Start is called before the first frame update
    // private void Start()
    // {
    //     mat.SetFloat("_DissolveAmmount", 1f);
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     if (!isShownCompletely)
    //     {
    //         if (dissolveAmount > 0f)
    //         {
    //             print("setting");
    //             mat.SetFloat("_DissolveAmmount", dissolveAmount);
    //             dissolveAmount -= Time.deltaTime;
    //             print("get float: " + mat.GetFloat("_DissolveAmmount"));
    //         }
    //         else
    //         {
    //             print("done");
    //             mat.SetFloat("_DissolveAmmount", 0f);
    //             isShownCompletely = true;
    //         }
    //     }
    //     
    // }
}