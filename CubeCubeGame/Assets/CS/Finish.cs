using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Transform pos;
    public Transform prev;
    public GameObject GG;
    public Camera cam;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = pos.transform.position;
        cam.transform.position = prev.transform.position;
    }
}
