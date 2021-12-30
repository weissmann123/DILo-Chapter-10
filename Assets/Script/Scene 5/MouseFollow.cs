using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public Rigidbody follow;
    public LayerMask hitLayers;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;//Get the mouse Position
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);//Cast a ray to get where the mouse is pointing at
            RaycastHit hit;//Stores the position where the ray hit.
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))//If the raycast doesnt hit a wall
            {
                follow.AddForce(hit.point * 50, ForceMode.Acceleration);
            }
        }
    }
}
