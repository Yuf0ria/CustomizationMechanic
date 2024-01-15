using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizationUI2 : MonoBehaviour
{
    [SerializeField] private Button Hair2, Head2, Shirt2, Pants2, Shoe2;//Slightly diff incase similar varibales collide
    [SerializeField] private PlayerCharacterCustomizationSecond playerCharacterCustomizationSecond;//FemScript


    private void Awake()
    {
        Hair2.onClick.AddListener(() => {
            //Debug.Log("HairKira");
            playerCharacterCustomizationSecond.ChangeBodyPart(PlayerCharacterCustomizationSecond.BodyPartType.HairKira);
        });
        Head2.onClick.AddListener(() => {
            //Debug.Log("HeadKira");
            playerCharacterCustomizationSecond.ChangeBodyPart(PlayerCharacterCustomizationSecond.BodyPartType.Head2);
        });
        Shirt2.onClick.AddListener(() => {
            //Debug.Log("shirt");
            playerCharacterCustomizationSecond.ChangeBodyPart(PlayerCharacterCustomizationSecond.BodyPartType.Shirt2);
        });
        Pants2.onClick.AddListener(() => {
            //Debug.Log("pants");
            playerCharacterCustomizationSecond.ChangeBodyPart(PlayerCharacterCustomizationSecond.BodyPartType.Pants2);
        });
        Shoe2.onClick.AddListener(() => {
            //Debug.Log("shoe");
            playerCharacterCustomizationSecond.ChangeBodyPart(PlayerCharacterCustomizationSecond.BodyPartType.Feet2);
        });
    }
}
