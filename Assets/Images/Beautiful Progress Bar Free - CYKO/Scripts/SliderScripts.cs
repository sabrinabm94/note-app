using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScripts : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public float maxTimeToFill = 300;
    protected float timer = 0f;

    void Start() {
        maxTimeToFill = slider.maxValue;
        slider.value = 0;
    }

    void Update() {
        timer += Time.deltaTime;

        if (timer < maxTimeToFill) {
            FillSlider(timer);
        }
    }

    public void FillSlider(float valueIncrement)
    {
        slider.value = slider.value + valueIncrement;
    }
}
