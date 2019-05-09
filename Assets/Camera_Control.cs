using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public enum RotationAxis{
    	MouseX = 1,
    	MouseY = 2
    }

    public RotationAxis axes = RotationAxis.MouseX;

    public float minVert = -45.0f;
	public float maxVert = 45.0f;


    public float sensHorz = 10.0f;
    public float sensVert = 10.0f;
    
    public float _rotationX = 0;

    // Update is called once per frame
    void Update()
    {
    	if(axes == RotationAxis.MouseX){
    		transform.Rotate(0,Input.GetAxis("Mouse X")*sensHorz,0);
    	}else if(axes == RotationAxis.MouseY){
    		_rotationX -= Input.GetAxis("Mouse Y") *sensVert;
    		_rotationX = Mathf.Clamp(_rotationX,minVert,maxVert);
    		float rotationY = transform.localEulerAngles.y;

    		transform.localEulerAngles = new Vector3 (_rotationX,rotationY,0);
    	}
    }
}
