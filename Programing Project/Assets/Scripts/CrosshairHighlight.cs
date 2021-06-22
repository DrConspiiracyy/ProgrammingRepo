using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CrosshairHighlight : MonoBehaviour
{

    private Ray g_ray = new Ray();
    public RaycastHit hitInteractable;
    public LayerMask layerToHit;
    public GraphicRaycaster raycaster;

    private bool rayHit = false;

    public float rayLength = 15f;

    public int InteractableObject;

    public Image Crosshair;


    private void Update()
    {

        g_ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Raycast From Mouse Position

        if (Physics.Raycast(g_ray, out hitInteractable, rayLength, layerToHit)) // If raycast hits collider 
        {
           if (hitInteractable.collider.tag == "Interactable Object") // if raycast hits collider with tag
            {
                rayHit = true;
            }
        }
        else // resets Raycast
        {
            rayHit = false;  
        }

        GameObject.Find("Crosshair").GetComponent<Image>();

        if (rayHit == true) //Turns the Crosshair green
        {
            Debug.Log("RaycastHit");
            Crosshair.GetComponent<Renderer>();
            Crosshair.color = Color.green;
        }
     
        if  (rayHit == false) // resets colour of crosshair
        {
            Crosshair.GetComponent<Renderer>();
            Crosshair.color = Color.white;
        }

    }
}

