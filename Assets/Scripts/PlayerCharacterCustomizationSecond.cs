using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterCustomizationSecond : MonoBehaviour
{
    [SerializeField] private BodyPartData[] bodyPartDataArray2;

    //Array for FemScript,seperated it to male script for optimized variables
    public enum BodyPartType
    {
        HairKira,
        Head2,
        Shirt2,
        Pants2,
        Feet2,
    }


    [System.Serializable]
    public class BodyPartData
    {
        public BodyPartType Type2;
        public Mesh[] meshArray2;
        public SkinnedMeshRenderer skinnedMeshRenderer2;
    }


    public void ChangeBodyPart(BodyPartType Type2)
    {
        BodyPartData bodyPartData = GetBodyPartData(Type2);
        int meshIndex = System.Array.IndexOf(bodyPartData.meshArray2, bodyPartData.skinnedMeshRenderer2.sharedMesh);
        bodyPartData.skinnedMeshRenderer2.sharedMesh = bodyPartData.meshArray2[(meshIndex + 1) % bodyPartData.meshArray2.Length];
    }
    private BodyPartData GetBodyPartData(BodyPartType Type2)
    {
        foreach (BodyPartData bodyPartData in bodyPartDataArray2)
        {
            if (bodyPartData.Type2 == Type2)
            {
                return bodyPartData;
            }
        }
        return null;
    }
}
