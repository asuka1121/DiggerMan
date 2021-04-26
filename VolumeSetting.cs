using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeSetting : MonoBehaviour
{
    public Slider slider;
    void Update()
    {
        FindObjectOfType<AudioManager>().SetVolume("BgMusic", slider.value);
    }
}
