using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BumpEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool _isApply = false;
 
    public int count = 0;

    public float minScale;
    public float maxScale;
    public float tick;

    private float m_delta;
    private Vector3 _originScale;
    void Start()
    {
        m_delta = 0f;
        _originScale = transform.localScale;
    }

    void Update()
    {
        if (_isApply && (count > 0 || count == -1))
        {
            m_delta += Time.deltaTime;

            if (m_delta >= tick)
            {
                m_delta = 0f;

                if (count != -1)
                    --count;
            }

            float size = Mathf.Lerp(minScale, maxScale, Mathf.Sin((m_delta / tick) * Mathf.PI));
            transform.localScale = new Vector3(size, size, size);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _isApply = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _isApply = false;
        transform.localScale = _originScale;
    }
}
