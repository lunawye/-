using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class shoot : MonoBehaviour
{
    
    public GameObject Magicball;
    public float speed = 25;
    public GameObject Light;
    public int num=0;
    public int num1=50;
    public int left=0;
    public GameObject canvas;
    public Text txt; 
    
        
    	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            num++;
            GameObject magicball = GameObject.Instantiate(Magicball, transform.position, transform.rotation);
            GameObject light = GameObject.Instantiate(Light, transform.position, transform.rotation);
            light.transform.position = magicball.transform.position;
            Rigidbody rgb = magicball.GetComponent<Rigidbody>();
            Rigidbody rgb1 = light.GetComponent<Rigidbody>();
            rgb.velocity = transform.forward * speed;
            rgb1.velocity = transform.forward * speed;
            if(num>=50)
            {
                Time.timeScale = 0;
                canvas.SetActive(true);
            }           
            left=(num1-num);
            //string varString = Convert.ToString(left); 
            string varString2 = left.ToString();
            
            string varString = "BALL LFET:";
            string varString3 = varString + varString2; 

            Text text = txt.transform.GetComponent<Text>();
            text.text =varString3; 
            Debug.Log(varString3);
        }
    }
}
