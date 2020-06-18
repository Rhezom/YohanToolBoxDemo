using UnityEngine;


[RequireComponent(typeof(ClapController))]
public class ClapShader : MonoBehaviour
{


    private void Update()
    {
        if (m_shaderRequested)
            ShaderRequested();
        else if (m_shaderShowed && m_currentTime >= m_timeOfShaderShowed)
            EndShaderShowed();
        else if (m_shaderShowed)
            m_currentTime += Time.deltaTime;
    }



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
    }

    private void EndShaderShowed()
    {
        m_shaderShowed = false;
    }


    #region Private Members

    [SerializeField]
    float m_timeOfShaderShowed;

    float m_currentTime;

    bool m_shaderShowed;
    bool m_shaderRequested;

    #endregion
}
