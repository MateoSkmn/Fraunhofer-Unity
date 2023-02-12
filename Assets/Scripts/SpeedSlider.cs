using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    public Slider slider;
    public float maxSpeed = 500;
    private RotateAroundObject rotate;

    // Start is called before the first frame update
    void Start()
    {
        rotate = GetComponent<RotateAroundObject>();
    }

    // Update is called once per frame
    void Update()
    {
        rotate.rotationSpeed = slider.value * maxSpeed;
    }
}
