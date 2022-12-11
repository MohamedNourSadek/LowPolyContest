using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_Move : MonoBehaviour
{
    [SerializeField] Animator myanimator;
    [SerializeField] GameObject parent_Object;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.gameObject.transform.SetParent(parent_Object.transform);

            if (myanimator.GetCurrentAnimatorStateInfo(0).IsName("1"))
            {
               myanimator.SetTrigger("Go");
            }
            else if (myanimator.GetCurrentAnimatorStateInfo(0).IsName("2"))
            {
               myanimator.SetTrigger("Back");
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.gameObject.transform.parent = null;
        }
    }
}
