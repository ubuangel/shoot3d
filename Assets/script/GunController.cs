using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public float sensitivity=5.0f;

    public GameObject dardo;
    public float dardospeed=10.0f;


    private Vector3 _angles=Vector3.zero;
    private readonly float _maxAngles = 60.0f;




    // Update is called once per frame
    void Update()


    {

        if (Input.GetKeyDown(KeyCode.F)||Input.GetMouseButtonDown(1))
        {
            DisparaDardo();
            
        }

        if (Input.GetMouseButton(0))
        {
          Cursor.lockState=CursorLockMode.Locked;
          float rotateHorizontal=Input.GetAxis("Mouse X");
          float rotateVertical=Input.GetAxis("Mouse Y");

          _angles.y +=rotateHorizontal*sensitivity;
          _angles.y=Mathf.Clamp(_angles.y,-_maxAngles,_maxAngles);

          _angles.x -=rotateVertical*sensitivity;
          _angles.x=Mathf.Clamp(_angles.x,-_maxAngles,_maxAngles);

          gameObject.transform.rotation=Quaternion.Euler(_angles);
          

        }
        else
        {

            Cursor.lockState=CursorLockMode.None;
        }
        
    }


    private void DisparaDardo(){

        GameObject newdardo=Instantiate(dardo);

        newdardo.transform.position=transform.position;
        newdardo.transform.rotation=transform.rotation;

        newdardo.GetComponent<Rigidbody>().velocity=newdardo.transform.forward * dardospeed;
    }

}
