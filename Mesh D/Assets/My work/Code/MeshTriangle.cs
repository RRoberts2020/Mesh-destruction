using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshTriangle : MonoBehaviour
{
    List<Vector3> vertices = new List<Vector3>();
    List<Vector3> normals = new List<Vector3>();
    List<Vector2> uvs = new List<Vector2>();
    int submeshIndex;

    public List<Vector3> Vertices { get { return Vertices; } set { Vertices = value; } }
    public List<Vector3> Normals { get { return Normals; } set { Normals = value; } }
    public List<Vector2> UVs { get { return UVs; } set { UVs = value; } }
    public int SubmeshIndex { get { return SubmeshIndex; } set { SubmeshIndex = value; } }

    public MeshTriangle(Vector3[] _vertices, Vector3[] _normals, Vector2[] _uvs, int _submeshIndex)
    {
        Clear();

        vertices.AddRange(_vertices);
        normals.AddRange(_normals);
        uvs.AddRange(_uvs);

        submeshIndex = _submeshIndex;
    }

    public void Clear()
    {
        vertices.Clear();
        normals.Clear();
        uvs.Clear();

        submeshIndex = 0;
    }
}
