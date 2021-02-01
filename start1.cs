using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start1 : MonoBehaviour
{
    public GameObject canvas;
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClickStart()
    {
        //canvas.transform.GetChild(2).gameObject.SetActive(false);
        //canvas.SetActiveRecursively(false);
        canvas.SetActive(false); 
        Time.timeScale = 1.0f;
    }
}
