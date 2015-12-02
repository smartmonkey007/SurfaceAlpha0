using UnityEngine;
using System.Collections;
using UnityEditor;
using RollSystems;
using Completed;

[CustomEditor(typeof(LevelManager))]
public class LevelManagerEditor : Editor
{
    void OnEnable()
    {
        // Setup the SerializedProperties.
  //      damageProp = serializedObject.FindProperty("damage");
    }
      
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        DrawDefaultInspector();

        if (GUILayout.Button("Generate Dungeon"))
        {
            var script = (LevelManager)target;
            script.SetupScene(1); 
            Debug.Log("generating dungeon");
        }

        serializedObject.ApplyModifiedProperties();

    }




}
