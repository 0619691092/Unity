using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Awake()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        goNextScene();
    }
 

    private void goNextScene()
    {
        if (transform.position.x >= 5) { 
            SceneManager.LoadScene("Play");
          }
    }
}
