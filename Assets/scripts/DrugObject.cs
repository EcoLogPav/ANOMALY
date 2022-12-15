using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DrugObject : MonoBehaviour,IInteracableObject
{
    private Rigidbody rigidBody;
    protected bool Picked { get; private set; }
    [SerializeField] private Vector3 DragOffset;
    [SerializeField] private float throwForce = 100f;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
   
    public  void StopInteract()
    {
        Picked= false;
        rigidBody.useGravity = true;
        rigidBody.AddForce(transform.parent.forward * throwForce);
        transform.SetParent (null);
        
    }
    
    public  void Interact(RaiseThrow raiseThrow)
    {
        Picked= true;
        transform.SetParent(raiseThrow.Container);
        transform.localPosition = DragOffset;
        rigidBody.useGravity = false;
        Debug.Log("1");
    }
    }
