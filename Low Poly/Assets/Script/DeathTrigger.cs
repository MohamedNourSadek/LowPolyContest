using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] GameObject SpawnObject;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            collider.transform.position = SpawnObject.transform.position;
        }
    }
}
