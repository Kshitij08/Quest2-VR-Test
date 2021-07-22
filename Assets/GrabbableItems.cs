using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableItems : OVRGrabbable
{

    [SerializeField] private Material isGrabbedMaterial;
    private Material originalMaterial;

    private Renderer _renderer;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        _renderer = GetComponent<Renderer>();
        originalMaterial = _renderer.material;
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        _renderer.material = isGrabbedMaterial;
    }


    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        _renderer.material = originalMaterial;
    }


}
