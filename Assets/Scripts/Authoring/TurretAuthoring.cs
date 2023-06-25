using Unity.Entities;
using UnityEngine;

class TurretAuthoring : MonoBehaviour
{
    // Bakers convert authoring MonoBehaviours into entities and components.
    public GameObject CannonBallPrefab;
    public Transform CannonBallSpawn;

    class Baker : Baker<TurretAuthoring>
    {
        public override void Bake(TurretAuthoring authoring)
        {
            // GetEntity returns the baked Entity form of a GameObject.
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new Turret
            {
                CannonBallPrefab = GetEntity(authoring.CannonBallPrefab, TransformUsageFlags.Dynamic),
                CannonBallSpawn = GetEntity(authoring.CannonBallSpawn, TransformUsageFlags.Dynamic)
            });

            AddComponent<Shooting>(entity);
        }
    }
}

public struct Turret : IComponentData
{
    // This entity will reference the nozzle of the cannon, where cannon balls should be spawned.
    public Entity CannonBallSpawn;

    // This entity will reference the prefab to be spawned every time the cannon shoots.
    public Entity CannonBallPrefab;
}

// This is a tag component that is also an "enableable component".
// Such components can be toggled on and off without removing the component from the entity,
// which would be less efficient and wouldn't retain the component's value.
// An Enableable component is initially enabled.
public struct Shooting : IComponentData, IEnableableComponent
{
}
