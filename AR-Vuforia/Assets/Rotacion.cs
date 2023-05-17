using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    bool rotando = true;
    private Color nuevoColor;

    void OnMouseDown()
    {
        rotando = !rotando;
        if (rotando==true) {
            nuevoColor = GenerarColorAleatorio();
            GetComponent<Renderer>().material.color = nuevoColor;
        }
    }

    private Color GenerarColorAleatorio()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (rotando) {
            transform.Rotate(new Vector3(0.0f, 0.2f, 0.0f));
        }
    }
}
