using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5: MonoBehaviour
{
    public float RandomSeed=6;
    private GameObject[] Creatures;
    void Start()
    {
        Creatures=Resources.LoadAll<GameObject>("C5");
        StartBuild();
    }
    void StartBuild()
    {
        float num = Random.Range(1,3);
        RenderComponent(Creatures, num);
    }
    void RenderComponent(GameObject[] pieceArray, float inputnum)
    {
        Transform randomTransform = pieceArray[Random.Range(0, pieceArray.Length)].transform;
        GameObject clone = Instantiate(randomTransform.gameObject, this.transform.position + new Vector3 (0, 0, 0), transform.rotation) as GameObject;
        Mesh cloneMesh = clone.GetComponentInChildren<MeshFilter>().mesh;
        Bounds bounds = cloneMesh.bounds;
        clone.transform.SetParent(this.transform);
    }
}