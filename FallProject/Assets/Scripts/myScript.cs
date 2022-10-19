using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour
{
    public int currentAge = 19;
    public int addAge = 1;

    /// Start is called before the first frame update
    void Start()
    {
        Debug.Log("What's 9 + 10?" + "\n" + currentAge);
        
    }

    // Update is called once per frame
    void Update()
    {
        ComputeAge();
    }

    void ComputeAge() {
        Debug.Log(currentAge + addAge);
    }
}
