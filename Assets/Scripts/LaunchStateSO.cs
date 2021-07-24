using UnityEngine;

[CreateAssetMenu(fileName = "new launch state so", menuName = "Game/Launch/LaunchStateSO")]
public class LaunchStateSO : ScriptableObject
{
    public bool IsLaunched;
    public bool IsColdLaunched;
}
