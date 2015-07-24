using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float camSpeed = 5f;
   
    
    
    void Update()
    {
        float mPosX = Input.mousePosition.x;
        float mPosY = Input.mousePosition.y;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {transform.Translate(Vector3.forward* camSpeed*Time.deltaTime, Space.World);}
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(Vector3.forward * -camSpeed * Time.deltaTime, Space.World); }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        { transform.Translate(Vector3.right * camSpeed * Time.deltaTime, Space.World); }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        { transform.Translate(Vector3.right * -camSpeed * Time.deltaTime, Space.World); }
        

        
        
    }
}
