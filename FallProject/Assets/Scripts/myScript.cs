using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour
{
    public int currentVar;
    public string playerName = "CrateHead";
    private int level;

    /// Start is called before the first frame update
    void Start()
    {
      Profile(playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Profile(string name) {
        Debug.Log(name + " | Level: " + level);
    }
    
    public void LevelManagement() {
        level++;
        Debug.Log(playerName + " | Level: " + level);
    }
}
