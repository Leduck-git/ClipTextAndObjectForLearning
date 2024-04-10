using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextVoidAreaShader : MonoBehaviour
{
    [SerializeField]
    private Transform Mascot;

    [SerializeField]
    private float threshold = 0.4f;

    [SerializeField]
    Camera mainCamera;

    void Update()
    {
        Vector2 screenPlaceOfBF = mainCamera.WorldToViewportPoint(Mascot.position);
        Vector2 screenPlace = mainCamera.WorldToViewportPoint(transform.position);
        if((screenPlace - screenPlaceOfBF).magnitude < threshold){
            this.GetComponent<MeshRenderer>().enabled = false;
        }else{
            this.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
