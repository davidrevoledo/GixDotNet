namespace GixDotnet
{
    /// <summary>
    ///     Version Values for sdk
    /// </summary>
    public class Versioning
    {
        /// <summary>
        ///     Minor version the sdk is supporting,
        ///     The same sdk should support do calls to multiple minor versions.
        /// </summary>
        public enum MinorVersion
        {
            _4 = 4
        }

        /// <summary>
        ///     The current mayor version the sdk is supporting
        ///     If this the mayor version change whole contract might change.
        /// </summary>
        public static int MayorVersion = 1;
    }
}