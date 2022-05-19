using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightArrangement : MonoBehaviour
{
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private Transform lightPrefabs;
    [SerializeField]
    private int numOfColumn=5;
    [SerializeField]
    private int numOfLightInRow = 10;
    [SerializeField]
    private Vector2 gap = new Vector2(2, 2);
    [SerializeField]
    private Vector2 randomMin = new Vector2(2,2);
    [SerializeField]
    private Vector2 randomMax = new Vector2(4, 4);
    [SerializeField]
    private Vector2 scaleMin = new Vector2(2, 2);
    [SerializeField]
    private Vector2 scaleMax = new Vector2(4, 4);
    [SerializeField]
    private float radius  = 10;
    [SerializeField]
    private Transform tree;
    [SerializeField]
    private List<Vector3> treePos=new List<Vector3>();
    private Transform[,] lights;
    void Start()
    {
        lights = new Transform[numOfColumn,numOfLightInRow];
        
        Vector2 startPos = new Vector2(radius,radius);
        tree.position = treePos[Random.Range(0, treePos.Count)];
        for (int i=0;i<numOfColumn;i++)
        {
            for(int j=0;j<numOfLightInRow;j++)
            {
                Transform transform = Instantiate(lightPrefabs, parent);
                lights[i, j] = transform;
                float gapX = Random.Range(randomMin.x, randomMax.x);
                float gapY = Random.Range(randomMin.y, randomMax.y);
                Debug.Log($"PosX:{gapX} PosY:{gapY}");
                transform.localPosition = new Vector3(gap.x*i+ gapX, gap.y * j + gapY, 0);
                transform.localScale = new Vector3(Random.Range(scaleMin.x, scaleMax.x), Random.Range(scaleMin.y, scaleMin.y),1);
            }
        }
    }
    
}
