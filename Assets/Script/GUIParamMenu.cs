using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIParamMenu : MonoBehaviour 
{
    [SerializeField] Text Name;
    [SerializeField] Text Param;


	// Use this for initialization
	void Start () 
    {
        SetParam();
	}

    void SetParam()
    {
        ParamManager param = CharacterManager.characterManager.GetCharaParam();
        Name.text = param.CP_Name;
        Param.text = "" + param.CP_HP + "\n" + param.CP_MP + "\n" + param.CP_Level;
    }
}
