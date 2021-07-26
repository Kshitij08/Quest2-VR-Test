using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonTrigger : MonoBehaviour
{

    public static event Action onButtonPressed;

    public Material isInteractingMaterial;
    public Material defaultMaterial;

    //private Animator buttonAnimator;


    // Start is called before the first frame update
    void Start()
    {
        defaultMaterial = GetComponent<Renderer>().material;
        //buttonAnimator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material = isInteractingMaterial;
            //buttonAnimator.SetTrigger("ButtonPressed");
            onButtonPressed?.Invoke();
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material = isInteractingMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material = defaultMaterial;
        }
    }

}
