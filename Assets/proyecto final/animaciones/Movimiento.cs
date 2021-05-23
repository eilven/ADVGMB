using System.Runtime.CompilerServices;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   
    public CharacterController charController;
    Animator animator;
    public float speed = 10;
    public float Downaccel = 100;
   public float _speed = 10;
   public float _rotSpeed= 100;
  // private Vector3 rotation;

    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
  
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
      //  this.rotation = new Vector3(0, H*_rotSpeed*time.deltaTime, 0);
        
    //    charController.Move(Vector3.down* Downaccel*Timeout.deltaTime);
       animator.SetFloat("vertical", 0);
       animator.SetFloat("horizontal",0);

    if(Input.GetKey(KeyCode.Y)){
        animator.SetFloat("vertical", 1);
        animator.SetFloat("horizontal", 1);
        

    }
      if(Input.GetKey(KeyCode.G)){
        animator.SetFloat("vertical", 0);
        animator.SetFloat("horizontal", -1);
        

    }
 if(Input.GetKey(KeyCode.J)){
        animator.SetFloat("vertical", 0);
        animator.SetFloat("horizontal", 1);
        

    }




        
    }
}
