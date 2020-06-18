using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleSystemManager : MonoBehaviour
{
    #region Unity Method

    private void Awake()
    {
        m_particleSystem = GetComponent<ParticleSystem>();
        
        
        m_timeDuration = m_particleSystem.main.duration;
        m_isLooping = m_particleSystem.main.loop;
    }


    private void Update()
    {
        if (!m_isLooping)
        {
            if (m_currentTime >= m_timeDuration)
                StopParticle();

            m_currentTime += Time.deltaTime;
        }
    }
    #endregion


    #region Own Method
    public void PlayParticle()
    {
        m_particleSystem.Play();
        m_currentTime = 0f;
    }


    public void StopParticle()
    {
        m_particleSystem.Stop();
    }
    #endregion


    #region Private Members
    ParticleSystem m_particleSystem;

    float m_timeDuration;

    bool m_isLooping;

    float m_currentTime;

    #endregion
}
