using UnityEngine;
using System.Collections;

public class UnitCintroller : MonoBehaviour {

    public Ray ray;
    public RaycastHit point;
    public Controller Controller;

    void Update(){
        
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out point)){}
            if(point.collider.gameObject.tag == ("Unit"))
            {
                

            }
        }
    }
}
