using Unity.Entities;
using UnityEngine;

class TankAuthoring : MonoBehaviour
{
    class TankBaker : Baker<TankAuthoring>
    {
        public override void Bake(TankAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent<Tank>(entity);
        }
    }
}

// Just like we did with the turret, we create a tag component to identify the tank (cube).
struct Tank : IComponentData
{
}
