using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject cube;
    VirtualButtonBehaviour vbutton;
    void Start()
    {
        cube.SetActive(false);
        vbutton = GetComponentInChildren<VirtualButtonBehaviour>();
        vbutton.RegisterOnButtonPressed(onButtonPressed);
        vbutton.RegisterOnButtonReleased(onButtonReleased);
    }

    void onButtonPressed( VirtualButtonBehaviour vb){
        cube.SetActive(true);
    }

    void onButtonReleased(VirtualButtonBehaviour vb){
        cube.SetActive(false);
    }


}
