using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using VGameFoundation.DI;
using VGameFoundation.Signals;

public struct TestSignal
{
    
}

public class SignalbusTesting : MonoBehaviour
{
    [Inject] private SignalBus signalBus;

    private void Start()
    {
        this.signalBus.TrySubscribe<TestSignal>(OnTestSignal);
        signalBus.Fire(new TestSignal());
        
    }

    private void OnTestSignal(TestSignal obj)
    {
        Debug.Log("hahhahaha");
    }
}
