using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hero : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent NavMeshAgent;
    public Animator anim;
    public int score = globle.score;
    public GameObject canvas;
    public GameObject hero11;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit;
           if(Physics.Raycast(ray,out hit))
           {
               NavMeshAgent.SetDestination(hit.point);
           }
       } 
       anim.SetFloat("Speed",NavMeshAgent.velocity.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "1")
        {
            Destroy(this.gameObject);
            globle.score=0;
            Debug.Log(globle.score+"Collide");
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
        else if(other.name == "2")
        {
            Destroy(this.gameObject);
            globle.score=0;
            Debug.Log(globle.score+"Collide");
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
        else if(other.name == "3")
        {
            Destroy(this.gameObject);
            globle.score=0;
            Debug.Log(globle.score+"Collide");
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
        else if(other.name == "dwarf_hero (4)")
        {
            Destroy(this.gameObject);
            globle.score=0;
            Debug.Log(globle.score+"Collide");
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
        else if(other.name == "dwarf_hero (5)")
        {
            Destroy(this.gameObject);
            globle.score=0;
            Debug.Log(globle.score+"Collide");
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
        else if(other.name == "dwarf_hero (6)")
        {
            Destroy(this.gameObject);
            globle.score=0;
            Debug.Log(globle.score+"Collide");
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
    }

}
