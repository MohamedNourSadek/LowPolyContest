using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master_Rotater : MonoBehaviour
{
    [SerializeField] List<Rotate> Planets = new List<Rotate>();
    [SerializeField] float Volume;
    [SerializeField] float Speed;
    
    AudioSource AD;
    float FinalVolume;

    private void Awake()
    {
        AD = GetComponent<AudioSource>();
        RotateObjects();
    }

    void RotateObjects()
    {
        foreach (Rotate planet in Planets)
            planet.Rotating = true;
    }

}
