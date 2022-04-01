using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textMeshProUGUI;
    private float timer, refresh, avrFragment;
    private float deltaTime;
    private int clickCount=0;
    private float clickTime = 0;
    [SerializeField]
    private float ExpireTime = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timeLapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timeLapse;
        if (timer <= 0) avrFragment = (int)(1f / timeLapse);
        //textMeshProUGUI.text = $"FPS:{avrFragment}";

        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        textMeshProUGUI.text = $"FPS:{Mathf.Ceil(fps)}";
        clickTime += Time.deltaTime;
        CheckDoubleTap();
    }
    private void CheckDoubleTap()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickCount++;
            Debug.Log($"Count:{clickCount} time:{clickTime}");
            if(clickTime< ExpireTime&&clickCount==2)
            {
                clickCount = 0;
                if (textMeshProUGUI.gameObject.activeSelf) textMeshProUGUI.gameObject.SetActive(false);
                else textMeshProUGUI.gameObject.SetActive(true);
            }
            clickTime = 0;
        }
    }
}
