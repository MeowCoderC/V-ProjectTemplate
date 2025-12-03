using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using VContainer;
using VGameFoundation.Scripts.Services.GameAsset;

public class GameAssetTesting : MonoBehaviour
{
    [Inject] private IGameAssets gameAssets;
    
    public GameObject testingPrefab;

    private async void Start()
    {
        this.testingPrefab = await this.gameAssets.LoadAssetAsync<GameObject>("TestAsset");
    }
}
