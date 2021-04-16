using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dianaAnimation : MonoBehaviour
{
    public Animator myAnimatorController;
        public Animator plataformaAnimator;


   private  void  Start()
   {
    
   
       
   }


     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flecha")){
          myAnimatorController.SetBool("Tocando" , true);
         plataformaAnimator.SetBool("subir", true);
      }   
    }

      }



