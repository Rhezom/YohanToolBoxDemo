using UnityEngine;
using UnityEngine.Events;

public class ClapController : MonoBehaviour
{
    #if UNITY_EDITOR
    public bool ActiveDebug;
    #endif


    #region Properties
    public float MinVelocityForClapping
    {
        get => m_minVelocityForClapping;
        private set => m_minVelocityForClapping = value;
    }

    public float MinDistanceForClapping
    {
        get => m_minDistanceForClapping;
        private set => m_minDistanceForClapping = value;
    }

    #endregion

    #region Unity Event

    public UnityEvent ControllerClappingEvent;

    #endregion

    #region Unity Method
    private void Update()
    {
        SetDistanceBetweenTwoControllers();
        CheckDistanceBetweenController();
    }


    #endregion


    #region Own Method
    private void SetDistanceBetweenTwoControllers()
    {
        if (m_firstController != null && m_secondController)
        {
            m_firstController.position.GetDistanceOptimized(m_secondController.position, out m_distanceBetweenTwoControllers);
            SetLastDistance();
        }
        else
            throw new System.Exception("First controller or/and Second controler variable is/are null. Please, check inspector variable");
    }


    private void SetLastDistance()
    {
        if (m_currentTime >= m_timeBetweenSetLastDistance)
        {
            m_lastDistanceBetweenTwoControllers = m_distanceBetweenTwoControllers;
            m_currentTime = 0f;
        }
        else
            m_currentTime += Time.deltaTime;

    }

    private void CheckDistanceBetweenController()
    {

        if(m_distanceBetweenTwoControllers <= MinDistanceForClapping)
        {
            if(((m_lastDistanceBetweenTwoControllers - m_distanceBetweenTwoControllers) / m_currentTime) >= MinVelocityForClapping)
            {
#if UNITY_EDITOR
               if(ActiveDebug) Debug.Log($"Speed : {(m_lastDistanceBetweenTwoControllers - m_distanceBetweenTwoControllers) / m_currentTime}");
#endif
                ControllerClappingEvent?.Invoke();
            }
        }
    }


    #endregion


    #region Private members
    [SerializeField, Range(0f, 100f)]
    float m_minVelocityForClapping;

    [SerializeField, Range(0f, 100f)]
    float m_minDistanceForClapping;

    [SerializeField]
    Transform m_firstController;

    [SerializeField]
    Transform m_secondController;

    [SerializeField]
    float m_timeBetweenSetLastDistance;

    float m_distanceBetweenTwoControllers;

    float m_lastDistanceBetweenTwoControllers;

    float m_currentTime;

    #endregion
}
