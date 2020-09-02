using Exiled.API.Features;

namespace BlindExplosion.Handlers
{
    public sealed class EventHandlers
    {
        public void OnDetonated()
        {
            Log.Warn("Warhead detonated");
            foreach(Player player in Player.List)
            {
                PlayerEffectsController effects = player.GameObject.GetComponentInParent<PlayerEffectsController>();
                effects.EnableEffect<CustomPlayerEffects.Blinded>(5);
            }
        }
    }
}
