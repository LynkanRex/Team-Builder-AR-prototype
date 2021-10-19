using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownButton : MonoBehaviour
{
    [SerializeField] private GameObject accordion;
    [SerializeField] private RectTransform rectTransform;
    
    public void SetChildPosition()
    {
        if (accordion.activeSelf)
        {
            transform.SetSiblingIndex(1);
            rectTransform.Rotate(0,0,-180);
        }
        else
        {
            transform.SetAsLastSibling();
            rectTransform.Rotate(0,0,180);
        }
    }
}
