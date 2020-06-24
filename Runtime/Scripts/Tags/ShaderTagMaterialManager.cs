using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ShaderTagMaterialManager : MonoBehaviour
{

    public static List<ShaderTagMaterialManager> ListObjectToWireframe = new List<ShaderTagMaterialManager>();


    private void Awake()
    {
        m_objectRenderer = GetComponent<Renderer>();

        int length = m_objectRenderer.materials.Length;
        m_defaultMaterials = new Material[length];
        Array.Copy(m_objectRenderer.materials, m_defaultMaterials, m_objectRenderer.materials.Length);
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
        m_objectRenderer.materials = new Material[1];
        m_objectRenderer.material = newMaterial;
    }

    public void ResetMaterial()
    {
        m_objectRenderer.materials = m_defaultMaterials;
    }

    #region Private Members

    private Renderer m_objectRenderer;
    private Material[] m_defaultMaterials;

    #endregion
}
