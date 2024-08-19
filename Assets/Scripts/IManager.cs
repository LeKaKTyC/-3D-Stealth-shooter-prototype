    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManager {
    string State { get; set; }
    void Initialize();
}



public abstract class BaseManager
{
    protected string _state;
    public abstract string State { get; set; }

    public abstract void Initialize();
}

public class CombatManager : BaseManager
{
    // 2
    public override string State
    {
        get { return _state; }
        set { _state = value; }
    }
    // 3
    public override void Initialize()
    {
        _state = "Manager initialized..";
        Debug.Log(_state);
    }
}