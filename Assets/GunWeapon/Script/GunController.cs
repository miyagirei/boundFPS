using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName ="CreateGunData")]
public class GunController : ScriptableObject
{
    [Header("銃の名前")]
    [SerializeField]
    string _gunName;

    [SerializeField] enum Type{ AutomaticRifle , SingleShot }
    [Header("武器種")]
    [SerializeField] Type type;
    [SerializeField] GunController(GunController gun){ this.type = gun.type; }


    [Header("跳ねる回数")]
    [SerializeField]
    int _boundLimit;

    [Header("購入に必要な金額")]
    [SerializeField]
    int _gunMoney;

    [Header("残弾数")]
    [SerializeField]
    int _shotCount;

    [Header("銃のコッキング")]
    [SerializeField]
    int _shotInterval;

    [Header("弾速default")]
    [SerializeField]
    int _shotSpeed;
}
