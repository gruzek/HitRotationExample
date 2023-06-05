using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSelector : MonoBehaviour
{
    public GameObject selectorObject=null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Generate a ray from the cursor position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.Log(Input.mousePosition);

        // Perform the raycast
        if (Physics.Raycast(ray, out hit))
        {
            // If it hits an object...
            // You can replace this with any action you want to perform on the object
            //Debug.Log("Mouse is over: " + hit.collider.gameObject.name);
            //Debug.Log("Hit object surface normal: " + hit.normal);
            if (selectorObject != null)
            {
                selectorObject.transform.position = hit.point;
                selectorObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            }
        } 
    }
}
