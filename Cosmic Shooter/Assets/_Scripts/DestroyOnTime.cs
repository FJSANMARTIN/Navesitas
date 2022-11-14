using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTime : MonoBehaviour
{
    public float time; // el tiempo que va a tardar en destruirse

 
    void Update()
    {
        Destroy(gameObject, time); //destruye el game object (aquel en el que este el scrip) tras pasar un tiempo "time"
    }
}
