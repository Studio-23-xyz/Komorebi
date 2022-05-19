using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafController : MonoBehaviour
{
    [SerializeField]
    private Transform leaf;
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private Vector3 minPos=new Vector3(-5,-5,-5);
    [SerializeField]
    private Vector3 maxPos = new Vector3(-1, -1, -1);
    [SerializeField]
    private Vector3 minRot = new Vector3(-5, -5, -5);
    [SerializeField]
    private Vector3 maxRot = new Vector3(5, 5, 5);
    [SerializeField]
    private Vector3 minScale = new Vector3(1, 1, 1);
    [SerializeField]
    private Vector3 maxScale = new Vector3(5, 5, 5);
    [SerializeField]
    private int num_of_leaf=100;
    [SerializeField]
    private List<Material> materials;


    void Start()
    {
        for(int i=0;i<num_of_leaf;i++)
        {
            Transform transform = Instantiate(leaf,parent);
            transform.localPosition = new Vector3(Random.Range(minPos.x,maxPos.x), Random.Range(minPos.y, maxPos.y), Random.Range(minPos.z, maxPos.z));
            transform.eulerAngles = new Vector3(Random.Range(minRot.x, maxRot.x), Random.Range(minRot.y, maxRot.y), Random.Range(minRot.z, maxRot.z));
            transform.localScale = new Vector3(Random.Range(minScale.x, maxScale.x), Random.Range(minScale.y, maxScale.y), Random.Range(minScale.z, maxScale.z));
            transform.GetComponent<SpriteRenderer>().material= materials[Random.Range(1, materials.Count)-1];
            transform.GetComponent<Animator>().speed = Random.Range(.02f, 1);
        }
    }
    
    private void OnDestroy()
    {
        parent.DestoryAllChildImmediate();
    }


}
