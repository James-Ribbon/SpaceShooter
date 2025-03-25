#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShipConfiguration))]
public class ShipConfigurationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ShipConfiguration config = (ShipConfiguration)target;

        EditorGUILayout.LabelField("Ship Configuration", EditorStyles.boldLabel);

        config.engine = (EngineSO)EditorGUILayout.ObjectField("Engine", config.engine, typeof(EngineSO), false);
        config.weapon = (WeaponSO)EditorGUILayout.ObjectField("Weapon", config.weapon, typeof(WeaponSO), false);
        //config.thruster = (ThrusterSO)EditorGUILayout.ObjectField("Thruster", config.thruster, typeof(ThrusterSO), false);

        if (config.engine != null)// && config.thruster != null)
        {
            EditorGUILayout.LabelField($"Total Thrust: {config.GetTotalThrust()}");
        }

        if (config.weapon != null)
        {
            EditorGUILayout.LabelField($"Fire Rate: {config.GetFireRate()}");
        }
    }
}
#endif