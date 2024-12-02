using System.Collections.Generic;
using UnityEngine;


public class BodyPart : MonoBehaviour
{
    [Header("Part Info")]
    public string partName;
    public List<string> descriptions = new List<string>();
    [Header("Settings")]
    public Color hoverColor = Color.white; 
    private Color originalColor;

    private MeshRenderer objectRenderer;

    private PartUIHandler partUIHandler;

    

    private void Awake()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        partUIHandler = FindObjectOfType<PartUIHandler>();
        if (objectRenderer != null)
        {
            originalColor = objectRenderer.material.color;
        }
    }

    private void OnMouseEnter()
    {
        
        if (objectRenderer != null)
        {
            objectRenderer.material.color = hoverColor;
        }

        
        OnHoverStart();
    }

    private void OnMouseExit()
    {
        
        if (objectRenderer != null)
        {
            objectRenderer.material.color = originalColor;
        }

        
        OnHoverEnd();
    }

    private void OnHoverStart()
    {
        
        Debug.Log($"Mouse started hovering over {gameObject.name}");

        partUIHandler.UpdateBodyInfo(partName, descriptions[partUIHandler.Day]);
    }

    private void OnHoverEnd()
    {
        
        Debug.Log($"Mouse stopped hovering over {gameObject.name}");
        partUIHandler.ResetBodyInfo();
    }
}
