using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScrollText : MonoBehaviour

{

    public TextMeshProUGUI TextMEshProComponenet;
    public float ScrollSpeed = 10;

    private TextMeshProUGUI m_cloneTextObject;

    private RectTransform m_textRectTransform;
    private string sourceText;
    private string tempText;

    // Start is called before the first frame update
    void Awake()
    {
        m_textRectTransform = TextMEshProComponenet.GetComponent<RectTransform>();
        m_cloneTextObject = Instantiate(TextMEshProComponenet) as TextMeshProUGUI;
        RectTransform clonerectTransform = m_cloneTextObject.GetComponent<RectTransform>();
        clonerectTransform.SetParent(m_textRectTransform);
        clonerectTransform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Start()
    {
        float width = TextMEshProComponenet.preferredWidth;
        Vector3 startPosition = m_textRectTransform.position;

        float scrollPosition = 0;

        while (true)
        {
            if (TextMEshProComponenet.transform.hasChanged)
            {
                width = TextMEshProComponenet.preferredWidth;
                m_cloneTextObject.text = TextMEshProComponenet.text;
            }
            
            m_textRectTransform.position = new Vector3(-scrollPosition % width, startPosition.y, startPosition.z);

            scrollPosition += ScrollSpeed * 20 * Time.deltaTime;

            yield return null;

        }


    }
}
