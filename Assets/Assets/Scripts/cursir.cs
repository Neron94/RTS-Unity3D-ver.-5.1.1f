using UnityEngine;
using System.Collections;

public class cursir : MonoBehaviour {

    public Texture2D cursor;
    public CursorMode mode = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;  
	void Start () {
        Cursor.SetCursor(cursor, hotspot, mode);
	
	}
	
}
