using System;
using Sirenix.OdinInspector;
using UnityEngine;
using VContainer;
using VGameFoundation.Scripts.Services.LocalData;

public class LocalDataTestingScript : MonoBehaviour
{
    [Inject] private IHandleUserDataServices handleLocalUserDataServices;
    [Inject] private UserDataManager userDataManager;
    [Inject] private LocalPlayerDataTesting localPlayerDataTesting;

    private async void Awake()
    {
        await this.userDataManager.LoadUserData();
    }

    [Button]
    public void SaveData()
    {
        handleLocalUserDataServices.SaveAll();
    }
    
    [Button]
    public void AddPlaye()
    {
        localPlayerDataTesting.Level++;
    }
}
