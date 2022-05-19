using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightArrangement2 : MonoBehaviour
{
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private Transform lightPrefabs;
    [SerializeField]
    private int numOfLight = 10;
    [SerializeField]
    private Vector2 randomMin = new Vector2(2,2);
    [SerializeField]
    private Vector2 randomMax = new Vector2(4, 4);
    [SerializeField]
    private Vector2 scaleMin = new Vector2(2, 2);
    [SerializeField]
    private Vector2 scaleMax = new Vector2(4, 4);
    private Transform[,] lights;
    void Start()
    {

        for (int j = 0; j < numOfLight; j++)
        {
            Transform transform = Instantiate(lightPrefabs, parent);
            float posX = Random.Range(randomMin.x, randomMax.x);
            float posY = Random.Range(randomMin.y, randomMax.y);
            transform.localPosition = new Vector3(posX, posY, 0);
            transform.localScale = new Vector3(Random.Range(scaleMin.x, scaleMax.x), Random.Range(scaleMin.y, scaleMin.y), 1);
        }
    }
    
}
