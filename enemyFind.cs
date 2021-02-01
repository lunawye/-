using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFind : MonoBehaviour
{

    public Transform hero;
    public GameObject enemy1;
    //public GameObject enemy2; 
    //public GameObject enemy3; 
    //public GameObject enemy4; 
    //public GameObject enemy5; 
    //public GameObject enemy6; 
    public GameObject canvas;
    public GameObject door;
    public int iscore=0;
    // Start is called before the first frame update
    void Start()
    {

    }


    //int SpeedUp = 1;
    //bool Automatic = true;
    //void Update ()
    //{
   //    if(Automatic)
	//	{
	//		transform.position=Vector3.MoveTowards(transform.position,hero.position,Time.deltaTime * SpeedUp);
	//	}
    //}


    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, hero.position, Time.deltaTime);



        //Ray ray = Camera.main.ScreenPointToRay(hero.position);
       // RaycastHit hit;
        //if(Physics.Raycast(ray,out hit))
       // {
       //     NavMeshAgent.SetDestination(hit.point);
        //}
      // anim.SetFloat("Speed",NavMeshAgent.velocity.magnitude);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Magicball(Clone)")
        {
            iscore++;
            if(iscore==3){
            Destroy(this.gameObject);
            globle.score++;
            Debug.Log(globle.score+"Continue");
            if(globle.score!=6)
            {
                door.IsActive()=false;
            }
            else if(globle.score==6)
            {
                door.IsActive()=true;
            }
            }

 
        }
    }
}



