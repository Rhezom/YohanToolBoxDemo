﻿using UnityEngine;


[RequireComponent(typeof(ClapController))]
public class ClapShader : MonoBehaviour
{
    #region Unity Method

    private void Update()
    {
        if (m_shaderRequested)
            ShaderRequested();
        else if (m_shaderShowed && m_currentTime >= m_timeOfShaderShowed)
            EndShaderShowed();
        else if (m_shaderShowed)
            m_currentTime += Time.deltaTime;
    }

    #endregion


    #region Own Method

    public void ChangeShaderRequestAction()
    {
        if (m_shaderShowed) return;
        else m_shaderRequested = true;
    }

    private void ShaderRequested()
    {
        m_shaderShowed = true;
        m_shaderRequested = false;
        m_currentTime = 0f;

        if (m_shaderMaterial != null)
        {
            foreach (ShaderTagMaterialManager shTag in ShaderTagMaterialManager.ListObjectToWireframe)
            {
                shTag.ChangeMaterial(m_shaderMaterial);
            }
        }
    }

    private void EndShaderShowed()
    {
        m_shaderShowed = false;
        foreach(ShaderTagMaterialManager shTag in ShaderTagMaterialManager.ListObjectToWireframe)
        {
            shTag.ResetMaterial();
        }
    }

    #endregion

    #region Private Members

    [SerializeField]
    float m_timeOfShaderShowed;

    [SerializeField]
    Material m_shaderMaterial;

    float m_currentTime;

    bool m_shaderShowed;
    bool m_shaderRequested;

    #endregion
}
