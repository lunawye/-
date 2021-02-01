using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youwin : MonoBehaviour
{
    public GameObject canvas;
    public GameObject enemy1;
    public GameObject enemy2; 
    public GameObject enemy3; 
    public GameObject enemy4; 
    public GameObject enemy5; 
    public GameObject enemy6; 
    public GameObject father;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        //if(father.GetComponentsInChildren<Transform>(true).Length<=1)
        //if(!(enemy1))
        //{
           // Time.timeScale = 0;
            //canvas.SetActive(true);
       // }
    }
    public void OnClickNextGame()
    {

        //SceneManager.LoadScene("SceneName");//场景跳转
        if(SceneManager.GetActiveScene().name == "SampleScene11")
        {
            AsyncOperation op = SceneManager.LoadSceneAsync("SampleScene");
            yield return new WaitForEndOfFrame();
            op.allowSceneActivation = true;
        }

    }
}
