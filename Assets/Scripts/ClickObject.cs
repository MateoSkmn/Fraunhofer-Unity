using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    private MeshRenderer meshCube;
    public MeshRenderer meshBall;

    private void Start()
    {
        meshCube = GetComponent<MeshRenderer>();

        meshCube.material.color = Color.black;
    }

    private void OnMouseDown()
    {
        SwitchColor(meshBall);
        SwitchColor(meshCube);
    }

    private void SwitchColor(MeshRenderer renderer)
    {
        renderer.material.color =
            renderer.material.color == Color.white ? Color.black : Color.white;
    }
}
