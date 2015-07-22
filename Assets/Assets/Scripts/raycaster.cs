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
            Debug.DrawLine(camera.position, hit.point, Color.yellow);
        }
    }
}
