using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoIndirecto : MonoBehaviour
{
    //NavMeshAgent variable control player movement
    public UnityEngine.AI.NavMeshAgent playerNavMeshAgent;

    //A Camera that follow player movement
    public Camera playerCamera;

    //Control the animation clips of player object 
    public Animator playerAnimator;
    public Animator tumbaAnimator;

    //check player is running(moving) or not
    public bool isRunning;

    private void Update()

    {

        //if the left button of is clicked
        if (Input.GetMouseButton(0))
        {
            //Unity cast a ray from the position of mouse cursor on-screen toward the 3D scene.
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;

            if (Physics.Raycast(myRay, out myRaycastHit))
            {

                //Assign ray hit point as Destination of Navemesh Agent (Player)
                playerNavMeshAgent.SetDestination(myRaycastHit.point);
            }
        }

        //Compare the value of the remaining distance and the stopping distance(Destination point)

        if (playerNavMeshAgent.remainingDistance <= playerNavMeshAgent.stoppingDistance)
        {
            //The remaining distance are less or equal than the stopping distance it means character stop moving and reached destination
            isRunning = false;
        }
        else
        {
            //If remaining distance are greater than the stopping distance than character still moving toward Destination
            isRunning = true;
        }

        playerAnimator.SetBool("IsRun", isRunning);
        while (isRunning)
        {
           

          //  tumbaAnimator.SetBool("roto", isRunning);
            isRunning = false;

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        print("dong");
        print(other.gameObject.name);
        Destroy(other.gameObject);
        if (other.gameObject.name == "tomb_Shape1")
        {
            
            print("soy 1");
            Destroy(other.gameObject);

            // tumbaAnimator.SetBool("roto", true);
        }
        if (other.gameObject.name == "tomb_Shape1 (4)")
        {
            print("winner");
           
            // tumbaAnimator.SetBool("roto", true);
        }
      
        
    }
    }
   

