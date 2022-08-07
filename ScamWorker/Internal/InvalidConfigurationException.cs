using System;

namespace ScamWorker.Internal
{
    [Serializable]
    internal class InvalidConfigurationException : Exception
    {
        internal InvalidConfigurationException(string message) : base(message)
        {
        }
    }
}
