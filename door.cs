using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        //print(other.name);
        if(other.name == "Door_000")
        {
            //实现场景切换
            StartCoroutine(Load());
        }        
    }

    IEnumerator Load()
    {
        //异步加载场景
        //要记得先把场景加载到build setting中才可以被切换

        if(SceneManager.GetActiveScene().name == "Room")
        {
            AsyncOperation op = SceneManager.LoadSceneAsync("TreasuryHouse");
            yield return new WaitForEndOfFrame();
            op.allowSceneActivation = true;
        }
        if(SceneManager.GetActiveScene().name == "SampleScene")
        {
            AsyncOperation op = SceneManager.LoadSceneAsync("Room");
            yield return new WaitForEndOfFrame();
            op.allowSceneActivation = true;
        }
        if(SceneManager.GetActiveScene().name == "SampleScene11")
        {
            AsyncOperation op = SceneManager.LoadSceneAsync("SampleScene");
            yield return new WaitForEndOfFrame();
            op.allowSceneActivation = true;
        }


        
    }
}
