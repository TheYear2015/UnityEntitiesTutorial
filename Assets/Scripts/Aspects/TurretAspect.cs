using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

// Instead of directly accessing the Turret component, we are creating an aspect.
// Aspects allows you to provide a customized API for accessing components.
public readonly partial struct TurretAspect : IAspect
{
    // This reference provides read only access to the Turret component.
    // Trying to access ValueRW (instead of ValueRO) from a RefRO is an error.
    readonly RefRO<Turret> m_Turret;

    // can represent entities which do not have this component.
    readonly RefRO<URPMaterialPropertyBaseColor> m_BaseColor;

    public Entity CannonBallSpawn => m_Turret.ValueRO.CannonBallSpawn;
    public Entity CannonBallPrefab => m_Turret.ValueRO.CannonBallPrefab;
    public float4 Color => m_BaseColor.ValueRO.Value;
}
