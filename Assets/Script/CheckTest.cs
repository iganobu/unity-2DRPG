using UnityEngine;
using System.Collections;

public class CheckTest : MonoBehaviour
{

    public ParamManager testParam;

	// Use this for initialization
	void Start () 
    {
        testParam = CharacterManager.characterManager.GetCharaParam(); 	    
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
