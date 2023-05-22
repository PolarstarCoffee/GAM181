using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLazer : MonoBehaviour
{
    private void Awake()
    {
        Destroy (gameObject, 1);
    }
}
