using UnityEngine;
using VGameFoundation.Scripts.Services.LocalData;

public class LocalPlayerDataTesting : ILocalData
{
    public int Level;
    public void Init()
    {
        Level = 1;
    }

    public void OnDataLoaded()
    {
        
    }
}
