using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipScript : MonoBehaviour
{
    public Animator Diver; 
    // Start is called before the first frame update
    void Awake()
    {
        Diver = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("Skip", 1.5f);
    }

    private void Skip()
    {
        Diver.Play("Skip animation");
    }
}
