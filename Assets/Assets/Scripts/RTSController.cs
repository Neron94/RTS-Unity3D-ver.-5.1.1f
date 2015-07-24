using UnityEngine;
using System.Collections;

public class RTSController: MonoBehaviour {

    
    public GameObject Unit;
    public Vector3 NachPoz;
    public Vector3 TochNaz;
    public float speed=10;
	public Ray ray;
	public RaycastHit hit;
	public int range;
	public Transform camera;
	public bool asignUnit = false;
    public bool move = false;


	void Update()
	{


		if(Input.GetMouseButtonDown(0)){

			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast(ray, out hit, range);
			Debug.DrawLine(camera.position, hit.point, Color.yellow);
			    

			     if(hit.collider.gameObject.tag==("Unit"))
                     {
				TochNaz = Unit.transform.position;
				asignUnit = true;
                NachPoz = Unit.transform.position;
				Unit = hit.collider.gameObject;
                     }
                
                if (hit.collider.gameObject.tag==("Terrain"))
                         {
				if(asignUnit== true)
				{
					TochNaz = hit.point;
                    move = true;
				}
                         }

		
	                           		}
		if (move == true){
			Unit.transform.position= Vector3.MoveTowards(Unit.transform.position,  TochNaz, speed*Time.deltaTime);
            if (Unit.transform.position == TochNaz)
            {
                NachPoz.Set(0, 0, 0);
                TochNaz.Set(0, 0, 0);
                move = false;
            }
                         }
	
		if(Input.GetMouseButtonDown(1)){
		asignUnit = false;
        NachPoz.Set(0,0,0);
        TochNaz.Set(0, 0, 0);
        move = false;
		}
	}
}



		


       
