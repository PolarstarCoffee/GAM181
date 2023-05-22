using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialChange : MonoBehaviour
{


    public Material materialNew; //new material to replace original material ref
    public GameObject enemy; //gameobject to change material for

    private void Start()
    {
        materialNew = enemy.GetComponent<Renderer>().material; //grab ref to material component on gameObject
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemy.GetComponent<Renderer>().material = materialNew;
        }
    }
}
