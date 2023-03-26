using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

class CannonBallAuthoring : UnityEngine.MonoBehaviour
{
    class CannonBallBaker : Baker<CannonBallAuthoring>
    {
        public override void Bake(CannonBallAuthoring authoring)
        {
            AddComponent<CannonBall>();
            AddComponent<URPMaterialPropertyBaseColor>();
        }
    }
}

struct CannonBall : IComponentData
{
    public float3 Speed;
}
