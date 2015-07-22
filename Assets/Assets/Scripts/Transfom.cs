using UnityEngine;
using System.Collections;

public class Transfom : MonoBehaviour {

    public GameObject Unit;
    public Vector3 NachPoz;
    public Vector3 TochNaz;
    public bool perekl = false;
    public raycaster raycaster;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (perekl == false)
            {
                if (raycaster.hit.collider.gameObject.tag == ("Unit"))
                {
                    Unit = raycaster.hit.collider.gameObject;
                    perekl = true;
                    NachPoz = Unit.transform.position;

                }
                else
                {
                   
                }


            }
            else if (perekl == true)
            {
                if (raycaster.hit.collider.gameObject.tag == ("Terrain"))
                {
                    TochNaz = raycaster.hit.point;
                    TochNaz = transform.position;
                    perekl = false;
                    

                }
            }

        }
    }
}
