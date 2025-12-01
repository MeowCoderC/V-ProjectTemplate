using UnityEngine;
using VContainer.Unity;

public class TestingService : ITickable
{
    public void Tick()
    {
        Debug.Log("Testing 2");
    }
}
