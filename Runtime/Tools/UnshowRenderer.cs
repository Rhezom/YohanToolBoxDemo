using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class UnshowRenderer : MonoBehaviour
{

    public bool IsDebug 
    { 
        get => m_isDebug; 
        private set => m_isDebug = value; 
    }
    [SerializeField]
    bool m_isDebug;

    void Start()
    {
        GetComponent<Renderer>().enabled = !m_isDebug;
    }
}
