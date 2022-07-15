using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="GunDataBase", menuName ="CreateGunDataBase")]
public class GunDataBase : ScriptableObject
{
    public List<GunController> guns = new List<GunController>();
}
