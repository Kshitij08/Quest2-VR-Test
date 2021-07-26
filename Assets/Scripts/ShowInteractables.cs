using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInteractables : MonoBehaviour
{

    public GameObject interactables;

    private void Start()
    {
        interactables.SetActive(false);
    }


    private void OnEnable()
    {
        ButtonTrigger.onButtonPressed += ActivateInteractables;
    }

    private void OnDisable()
    {
        ButtonTrigger.onButtonPressed -= ActivateInteractables;
    }

    private void ActivateInteractables()
    {
        interactables.SetActive(true);
    }


}
