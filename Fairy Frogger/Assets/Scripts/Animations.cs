using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator anim;
  
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("moving", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("moving", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("moving", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("moving", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("moving", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("moving", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("moving", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("moving", false);
        }
    }
}
