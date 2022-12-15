using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseThrow : MonoBehaviour
{
    private IInteracableObject CurrentObject;
    [SerializeField] private KeyCode DropButton;
    [SerializeField] private KeyCode PickButton;
    [SerializeField] private Transform CenterArm;
    [SerializeField] private Transform Arm;
    [SerializeField] private KeyCode UseButton;

    public static Rigidbody DrugObject;
    public static byte inventoryStep = 0;
    
    private bool drug = false;
    private float throwPower = 50f; 
    
    [SerializeField] private float RayDistance= 2f;

    public Transform Container=>Arm;
    void Update()
    {
        if (Input.GetKeyDown(UseButton))
        {
            if(CurrentObject is PickInteractableObject)
            {
                (CurrentObject as PickInteractableObject).Use();
            }
        }
        if (Input.GetKeyDown(PickButton))
            {
            if (CurrentObject == default(IInteracableObject))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                Debug.DrawRay(transform.position, new Vector3(Screen.width / 2, Screen.height / 2, 0), Color.green);
                if (Physics.Raycast(ray, out hit, RayDistance))
                {
                    if (hit.collider.TryGetComponent<IInteracableObject>(out IInteracableObject interactable))
                    {

                        interactable.Interact(this);
                        CurrentObject = interactable;
                    }

                }
            }
            else
            {
                CurrentObject.StopInteract();
                CurrentObject = default(IInteracableObject);
            }
        }
       
    }
    

}

