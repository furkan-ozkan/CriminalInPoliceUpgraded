using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Informations/House/House")]
public class HouseInformations : ScriptableObject
{
    public string houseNo;
    [Range(0,23)]public int freeTimeStart,freeTimeEnd;
    public Citizen citizen;
}
