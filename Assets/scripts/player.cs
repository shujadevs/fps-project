using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    CharacterController mycc;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        mycc = GetComponent<CharacterController>();  
        if(mycc == null)
        {
            Debug.Log("CharacterController component not found on this game object.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float rlmv = Input.GetAxisRaw("Horizontal");
        float frmv = Input.GetAxisRaw("Vertical");

        Vector3 movelr = transform.right * rlmv;
        Vector3 movefb = transform.forward * frmv;

        mycc.Move((movelr + movefb) * speed * Time.deltaTime);

        float mouseviewx = Input.GetAxisRaw("Mouse X");
        transform.Rotate(Vector3.up * mouseviewx * mouseSensitivity * Time.deltaTime);

    }
}
