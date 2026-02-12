using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDownLooking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseyinput = Input.GetAxisRaw("Mouse Y");

        float camermovementupdown = -mouseyinput;

        float finalheamovementupdown = Mathf.Clamp(camermovementupdown, -90f, 90f);

        transform.rotation = Quaternion.Euler(finalheamovementupdown, 0, 0);
    
    }
}
