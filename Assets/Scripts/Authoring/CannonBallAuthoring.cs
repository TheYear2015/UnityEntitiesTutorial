using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

class CannonBallAuthoring : UnityEngine.MonoBehaviour
{
    class CannonBallBaker : Baker<CannonBallAuthoring>
    {
        public override void Bake(CannonBallAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);

            // By default, components are zero-initialized,
            // so the Velocity field of CannonBall will be float3.zero.
            AddComponent<CannonBall>(entity);

            AddComponent<URPMaterialPropertyBaseColor>(entity);
        }
    }
}

public struct CannonBall : IComponentData
{
    public float3 Velocity;
}
