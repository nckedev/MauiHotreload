using hotreload.shared;

#if NET6_0_OR_GREATER && DEBUG
[assembly: System.Reflection.Metadata.MetadataUpdateHandlerAttribute(typeof(hotreload.shared.HotReloadService))]
#endif
namespace hotreload.shared
{
    public static class HotReloadService
    {

        public static event Action<Type[]?>? UpdateEvent;

#if NET6_0_OR_GREATER && DEBUG
        internal static void UpdateApplication(Type[] types)
        {
            if (types != null && types.Length > 0 && types[0] != null)
            {
                UpdateEvent?.Invoke(types);
            }
        }
#endif
    }
}