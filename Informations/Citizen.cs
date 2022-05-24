using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Informations/Citizen/Citizen")]
public class Citizen : ScriptableObject
{
    public string citizenName;
    public HouseInformations house;
    [Range(0,23)]public int walkTimeStart,walkTimeEnd;
}
