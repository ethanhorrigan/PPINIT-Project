using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[RequireComponent(typeof(Camera))]
public class TwoPlayerCamera : MonoBehaviour
{
    public List<Transform> players;
    public float smoothTime = .5f;

    public float minZoom = 140f;
    public float maxZoom = 170f;
    public float zoomLimit = 40f;

    public Vector3 offset;

    private Vector3 velocity;
    private Camera cam;

    void Start(){

        cam = GetComponent<Camera>();

    }

    void LateUpdate(){



        if(players.Count == 0){
            return;
        }

        MoveCam();
        ZoomCam();

    }

    void ZoomCam(){

        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetMaxDistance() / zoomLimit);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
        
    }

    float GetMaxDistance(){

        var bounds = new Bounds(players[0].position, Vector3.zero);
        for(int i = 0; i < players.Count; i++){
            bounds.Encapsulate(players[i].position);
        }

        return bounds.size.x;
    }

    void MoveCam(){

        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPos = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothTime);

    }

    Vector3 GetCenterPoint(){

        if(players.Count == 1){
            return players[0].position;
        }

        var bounds = new Bounds(players[0].position, Vector3.zero);
        for(int i = 0; i < players.Count; i++){
            bounds.Encapsulate(players[i].position);
        }

        return bounds.center;
    }
}
