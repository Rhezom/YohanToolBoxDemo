using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField]
    private Renderer m_targetRenderer;

    public Renderer TargetRenderer
    {
        get { return m_targetRenderer; }
        set { m_targetRenderer = value; }
    }


    [SerializeField]
    private KeyCode m_inputKey;

    public KeyCode InputKey
    {
        get { return m_inputKey; }
        set { m_inputKey = value; }
    }

    [SerializeField]
    private float m_waitingTimeBeforeNextColor;

    public float WaitingTimeBeforeNextColor
    {
        get { return m_waitingTimeBeforeNextColor; }
        set { m_waitingTimeBeforeNextColor = value; }
    }





    private bool m_canChangeColor = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(InputKey))
        {
            ChangeColor();
        }
    }

    public void ChangeColor()
    {
        TargetRenderer.sharedMaterial.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.5f);
    }

    public void ResetColor()
    {
        TargetRenderer.sharedMaterial.color = new Color(1f, 1f, 1f, 1f);
    }

    private void Reset()
    {
        TargetRenderer = GetComponent<Renderer>();
        InputKey = KeyCode.Space;
        WaitingTimeBeforeNextColor = 2f;
    }
}
