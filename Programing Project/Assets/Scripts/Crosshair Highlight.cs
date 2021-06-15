using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairHighlight : MonoBehaviour
{

    private Ray ray = new Ray();
    public RaycastHit hitInteractable;
    public LayerMask layerToHit;
    public GraphicRaycaster raycaster;

    public float rayLength = 10f;
    public KeyCode boundKey; 

    public int InteractableObject; 

}

void Start()
{




}

private void Update()
{
    GameObject.Find("Crosshair").GetComponent<Image>();

    ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    if (hitInteractable)
    {
        Crosshair.color = Color.green;
    }

    


}

