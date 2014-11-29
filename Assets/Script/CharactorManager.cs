using UnityEngine;
using System.Collections;

public class CharacterManager : MonoBehaviour 
{
    public static CharacterManager characterManager;
    public string                  CP_Name;
    public int CP_Level;
    public int CP_EXP;
    public int CP_HP;
    public int CP_MaxHP;
    public int CP_MP;
    public int CP_MaxMP;
    public int CP_ParamName;
    public int CP_ParamPower;
    public int CP_ParamSpeed;
    public int CP_ParamIntelligence;

    public void OnEnable() 
    {
        if( characterManager == null ){
            characterManager = this;
        }
    }

	void Awake () {
        DontDestroyOnLoad( this );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
