using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] Master_Rotater Button;
    [SerializeField] public bool Rotating;
    [SerializeField] float Speed;


    private void FixedUpdate()
    {
        if(Rotating)
            transform.Rotate(0f, Time.fixedDeltaTime * Speed, 0f);
    }
}
