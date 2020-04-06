using System;

namespace Plugin.Snackbars
{
    /// <summary>
    /// Cross Snackbar
    /// </summary>
    public static class CrossSnackbar
    {
        private static readonly Lazy<ISnackbar> Implementation = new Lazy<ISnackbar>(CreateSnackbar, System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => Implementation.Value != null;

        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static ISnackbar Current
        {
            get
            {
                ISnackbar snackbar = Implementation.Value;
                if (snackbar == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return snackbar;
            }
        }

        private static ISnackbar CreateSnackbar()
        {
#if NETSTANDARD1_0 || NETSTANDARD2_0
            return null;
#else
#pragma warning disable IDE0022 // Use expression body for methods
            return new SnackbarImplementation();
#pragma warning restore IDE0022 // Use expression body for methods
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("This functionality is not implemented in the portable version of this assembly. You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }

    public enum Duration
    {
        LengthIndefinite = -2,
        LengthShort = -1,
        LengthLong = 0
    }
}
