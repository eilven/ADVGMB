using System;
using System.Numerics;
using System.Diagnostics;
using System.Diagnostics.Contracts;
//using System.Reflection.PortableExecutable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofreAnimacion : MonoBehaviour
{
        public  Animator cofre;
        public bool estado = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
private void  OnTriggerEnter(Collider other)   
{
   if (other.CompareTag("Flecha")){
      estado = !estado;
      cofre.SetBool("abierto" , estado);

    }
   }
}
