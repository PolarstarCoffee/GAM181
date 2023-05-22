using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialChange : MonoBehaviour
{


    public Material materialNew; //new material to replace original material ref
    public GameObject enemy; //gameobject to change material for
    public GameObject enemy2;

    private void Start()
    {
       // materialNew = enemy.GetComponent<Renderer>().material; //grab ref to material component on gameObject
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Entered");
            enemy.GetComponent<Renderer>().material = materialNew;
            enemy2.gameObject.GetComponent<Renderer>().material = materialNew;
        }
    }
}
