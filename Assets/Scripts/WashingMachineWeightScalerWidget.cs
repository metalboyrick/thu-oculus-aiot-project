using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachineWeightScalerWidget : Sensor
{
    [SerializeField] float _requiredWeight = 0.0f;
    private ArrayList _colliders = new ArrayList(); // A list of object currently colliding with the scaler
    public float _totalWeight;
    public GameObject dryer;
    public float CurrentWeight
    {
        get
        {
            return _totalWeight;
        }
        set
        {
            _totalWeight = value;
        }
    }

    public override void Update()
    {
        base.Update();
        _totalWeight = 0f;

        // add up the weight of all objects
        for (int i = 0; i < _colliders.Count; i++)
        {
            Rigidbody rigidbody = (_colliders[i] as GameObject).GetComponent<Rigidbody>();

            if (rigidbody)
                _totalWeight += rigidbody.mass;
        }

        // press the switch if total weight meets requirement
        if (_totalWeight > _requiredWeight)
        {
            SensorTrigger();
        }
        else
        {
            SensorUntrigger();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        _colliders.Add(col.gameObject);
    }

    void OnCollisionExit(Collision col)
    {
        _colliders.Remove(col.gameObject);
    }

    Vector3 getRelativeTransform(GameObject dryer){
        return dryer.transform.position - this.transform.position;
    }

    public void moveClothes(){
        for (int i = 0; i < _colliders.Count; i++)
        {
            GameObject clothes = (_colliders[i] as GameObject);
            clothes.transform.position = clothes.transform.position + getRelativeTransform(dryer);
        }
    }
}
