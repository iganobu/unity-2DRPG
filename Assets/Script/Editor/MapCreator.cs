using UnityEngine;
using UnityEditor;
using System.Collections;

public class MapCreator : EditorWindow 
{
    private GameObject parent = null;
    private GameObject prefab = null;
    private int numX = 1;
    private int numY = 1;
    private float interbalX = 0.31f;
    private float interbalY = 0.15f;


    [MenuItem("Window/MapEditor")]
    static void Open()
    {
        EditorWindow.GetWindow<MapCreator>( "MapEditor" );
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField( "CREATE MAP!" );
        parent = EditorGUILayout.ObjectField( "Parent", parent, typeof(GameObject), true ) as GameObject;
        prefab = EditorGUILayout.ObjectField( "Prefab", prefab, typeof(GameObject), true ) as GameObject;

        GUILayout.Label("", EditorStyles.boldLabel);

        numX = EditorGUILayout.IntField( "X : ", numX );
        numY = EditorGUILayout.IntField( "Y : ", numY );

        GUILayout.Label( "", EditorStyles.boldLabel );
        if (GUILayout.Button("Create!")){
            Create();
        }
    }

    void Create()
    {
        if (prefab == null || parent == null) return;

        int count = 1;
        Vector3 pos;
        SpriteRenderer renderTarget;

        for(int x = 0; x < numX; x++){
            pos.x = -(x * interbalX);
            pos.y = x * interbalY;
            pos.z = 0f;
            for (int y = 0; y < numY; y++)
            {
                pos.x += interbalX;
                pos.y += interbalY;
                GameObject obj = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;

                obj.name = obj.name + count;
                Transform tr = obj.transform;
                tr.parent = parent.transform;
                tr.position = tr.parent.position + pos;
                count++;

                renderTarget = obj.GetComponent<SpriteRenderer>();
                renderTarget.sortingOrder = (numX - x) + (numY - y);
            }
        }
    }
}
