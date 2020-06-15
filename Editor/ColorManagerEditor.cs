using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.TerrainAPI;
using UnityEngine;

[CustomEditor(typeof(ColorManager))]
public class ColorManagerEditor : Editor
{
    private ColorManager m_colorManager;

    public ColorManager ColorManager
    {
        get { return m_colorManager; }
        set { m_colorManager = value; }
    }



    private void OnEnable()
    {
        m_colorManager = (ColorManager)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Random Color"))
            m_colorManager.ChangeColor();
        else if (GUILayout.Button("Reset Color"))
            m_colorManager.ResetColor();
    }
}
