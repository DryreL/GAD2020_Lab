using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight : MonoBehaviour
{

    private Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myLight = this.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            myLight.enabled = !myLight.enabled;
        }

    }
}
