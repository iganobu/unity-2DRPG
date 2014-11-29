using UnityEngine;
using System.Collections;

public class CharacterManager : MonoBehaviour 
{
    public static CharacterManager characterManager;

    ParamManager param;

    public TextAsset LevelCSV;

    enum ParamParamater
    {
        LEVEL = 0,
        HP,
        MP,
        POWER,
        SPEED,
        INTELLIGENCE,
    }

    public void OnEnable() 
    {
        if( characterManager == null ){
            characterManager = this;
        }
    }

	void Awake()
    {
        param = new ParamManager();
        DontDestroyOnLoad( this );
        SetLevel( 1 );
	}

    public ParamManager GetCharaParam()
    {
        return param;
    }

    public void SetLevel( int num )
    {
        string[] lines = LevelCSV.text.Split( "\n"[0] );
        string[] values = lines[num].Split( ',' );
        int[] LevelParam = new int[6];

        for (int i = 0; i < values.Length; i++){
            LevelParam[i] = int.Parse( values[i] );
        }

        param.CP_Level = LevelParam[(int)ParamParamater.LEVEL];
        param.CP_HP = LevelParam[(int)ParamParamater.HP];
        param.CP_MaxHP = LevelParam[(int)ParamParamater.HP];
        param.CP_MP = LevelParam[(int)ParamParamater.MP];
        param.CP_MaxMP = LevelParam[(int)ParamParamater.MP];
        param.CP_ParamPower = LevelParam[(int)ParamParamater.POWER];
        param.CP_ParamSpeed = LevelParam[(int)ParamParamater.SPEED];
        param.CP_ParamIntelligence = LevelParam[(int)ParamParamater.INTELLIGENCE];
    }
}
