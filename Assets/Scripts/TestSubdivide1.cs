using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Subdivision
{
    public class TestSubdivide1 : MonoBehaviour
    {
        private ISubdiviser subdiviser;
        [SerializeField] private MeshFilter meshFilter;
        //[SerializeField] private MeshFilter meshFilter1;
        private Mesh originalMesh;
        private int iterations = 1;
       void Start()
        {

                this.subdiviser = new LoopSubdivisionSurface(SubdivisionUtils.Weld(meshFilter.mesh, float.Epsilon, meshFilter.mesh.bounds.size.x), iterations);
                this.subdiviser.Subdivide(iterations);
                this.meshFilter.mesh = this.subdiviser.GetMesh();
             
        }
    }
}