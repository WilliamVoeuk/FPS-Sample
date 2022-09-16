using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red, 2f);
        var myLayerMask = LayerMask.GetMask("Joueur", "Default");
        if(Physics.Raycast(transform.position, transform.forward, out var hitInfo, 2f))
        {

        }

    }
}
