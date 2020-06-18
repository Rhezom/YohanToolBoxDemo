using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ShaderTagMaterialManager : MonoBehaviour
{

    public static List<ShaderTagMaterialManager> ListObjectToWireframe = new List<ShaderTagMaterialManager>();


    private void Awake()
    {
        m_objectRenderer = GetComponent<Renderer>();
        m_defaultMaterial = m_objectRenderer.material;
    }

    void Start()
    {
        ListObjectToWireframe.Add(this);
    }

    void OnDestroy()
    {
        ListObjectToWireframe.Remove(this);
    }


    public void ChangeMaterial(Material newMaterial)
    {
        m_objectRenderer.material = newMaterial;

    }

    public void ResetMaterial()
    {
        m_objectRenderer.material = m_defaultMaterial;
    }

    #region Private Members

    private Renderer m_objectRenderer;
    private Material m_defaultMaterial;

    #endregion
}
