using BlindExplosion.Handlers;
using Exiled.API.Enums;
using Exiled.API.Features;
using System;

using Player = Exiled.Events.Handlers.Player;

namespace BlindExplosion
{
    public class BlindExplosion : Plugin<Config>
    {
        private static readonly Lazy<BlindExplosion> LazyInstance = new Lazy<BlindExplosion>(valueFactory: () => new BlindExplosion());
        public BlindExplosion Instance => LazyInstance.Value;

        private EventHandlers EventHandlers;

        public override string Name { get; } = "RealisticSizes";
        public override string Author { get; } = "JesusQC";

        public override void OnEnabled()
        {
            base.OnEnabled();

            RegisterEvents();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            EventHandlers = new EventHandlers();

            Exiled.Events.Handlers.Warhead.Detonated += EventHandlers.OnDetonated;
        }

        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Warhead.Detonated -= EventHandlers.OnDetonated;

            EventHandlers = null;
        }
    }
}