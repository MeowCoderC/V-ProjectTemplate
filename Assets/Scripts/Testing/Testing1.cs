using UnityEngine;
using VContainer;
using VContainer.Unity;
using VGameFoundation.DI;

public class Testing1 : MonoBehaviour, ITickable
{
    public void Tick()
    {
        Debug.Log("Testing 1");
    }
}
