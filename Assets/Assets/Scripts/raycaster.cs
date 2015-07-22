using UnityEngine;
using System.Collections;

public class raycaster : MonoBehaviour {

    public Ray ray;
    public RaycastHit hit;
    public int range;
    public Transform camera;
   

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, range);
            if (hit.collider.gameObject.tag == ("Unit"))
            {
                Debug.Log("Eto Unit");
            }
            if (hit.collider.gameObject.tag == ("Terraain"))
            {
                
            }
            Debug.DrawLine(camera.position, hit.point, Color.yellow);
        }
    }
}
