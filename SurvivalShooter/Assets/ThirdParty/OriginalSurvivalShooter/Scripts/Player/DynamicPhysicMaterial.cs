using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicPhysicMaterial : MonoBehaviour {

    private PhysicsMaterial pMat;

    private void Start()
    {
        pMat = new PhysicsMaterial();

        pMat.dynamicFriction = 0.5f;
        pMat.frictionCombine = PhysicsMaterialCombine.Minimum;

        pMat.bounciness = 0.5f;
        pMat.bounceCombine = PhysicsMaterialCombine.Maximum;
    }
}
