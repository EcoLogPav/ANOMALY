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
    [SerializeField] private RaiseThrow Arm;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
            }
   
    public  void StopInteract()
    {
        rigidBody.freezeRotation = false ;
        Picked = false;
        rigidBody.GetComponent<Collider>().enabled = true;
       
        rigidBody.useGravity = true;
        rigidBody.AddForce(transform.parent.forward * throwForce);
        transform.SetParent (null);
        
    }
    
    public  void Interact(RaiseThrow raiseThrow)
    {
        Picked= true;
       rigidBody.GetComponent<Collider>().enabled = false;
       
        rigidBody.freezeRotation = true;
        transform.SetParent(raiseThrow.Container);
        transform.localPosition = DragOffset;
        rigidBody.useGravity = false;
        Debug.Log("1");
    }
    public void StopInteractWeakly()
    {
        rigidBody.freezeRotation = false;
        Picked = false;
        rigidBody.GetComponent<Collider>().enabled = true;

        rigidBody.useGravity = true;
       
        transform.SetParent(null);
    }
    }
