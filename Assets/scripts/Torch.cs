using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : PickInteractableObject
{
    [SerializeField] private GameObject light;
    public override void Use()
    {
        
        light.SetActive(!light.activeSelf);
    }
}
