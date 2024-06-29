using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InteractionScrtipt : MonoBehaviour
{
    public GameObject MouseObject;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        MouseObject.transform.position = mousePosition;
    }
}
