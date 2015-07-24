using UnityEngine;
using System.Collections;

public class Transfom : MonoBehaviour {

    public GameObject Unit;
    public Vector3 NachPoz;
    public Vector3 TochNaz;
    public float speed=0;
	public Ray ray;
	public RaycastHit hit;
	public int range;
	public Transform camera;
	public bool asignUnit = false;


	void Update()
	{


		if(Input.GetMouseButton(0)){

			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast(ray, out hit, range);
			Debug.DrawLine(camera.position, hit.point, Color.yellow);
			    

			     if(hit.collider.gameObject.tag==("Unit")){
				speed = 10;

				TochNaz = Unit.transform.position;
				asignUnit = true;


				NachPoz = Unit.transform.position;
				Unit = hit.collider.gameObject;


			                      											}


			if (hit.collider.gameObject.tag==("Terrain")){
				if(asignUnit== true)
				{
					TochNaz = hit.point;
				}
                                                                           }

		
	                           					}
		if (asignUnit == true){
			Unit.transform.position= Vector3.MoveTowards(Unit.transform.position,  TochNaz, speed*Time.deltaTime);}
	
		if(Input.GetMouseButton(1)){
			speed = 0;
			asignUnit = false;
		}
	}
}



		


       
