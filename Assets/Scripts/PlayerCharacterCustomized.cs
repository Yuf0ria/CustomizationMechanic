using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChracterCustomized : MonoBehaviour
{
    [SerializeField] private BodyPartData[] bodyPartDataArray;


    public enum BodyPartType
    {
        HairLiam,
        Head,
        Shirt,
        Pants,
        Feet,
    }

    //An array to Group similar Mesh Renders
    [System.Serializable]
    public class BodyPartData
    {
        public BodyPartType Type;
        public Mesh[] meshArray;
        public SkinnedMeshRenderer skinnedMeshRenderer;
    }


    public void ChangeBodyPart(BodyPartType Type)
    {
        BodyPartData bodyPartData = GetBodyPartData(Type);
        int meshIndex = System.Array.IndexOf(bodyPartData.meshArray, bodyPartData.skinnedMeshRenderer.sharedMesh);
        bodyPartData.skinnedMeshRenderer.sharedMesh = bodyPartData.meshArray[(meshIndex + 1) % bodyPartData.meshArray.Length];
    }
    private BodyPartData GetBodyPartData(BodyPartType Type)
    {
        foreach (BodyPartData bodyPartData in bodyPartDataArray)
        {
            if(bodyPartData.Type == Type)
            {
                return bodyPartData;
            }
        }
        return null;
    }

}
