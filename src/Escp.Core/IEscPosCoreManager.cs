using System;

namespace Escp.Core
{
    public interface IEscPosCoreManager : IDisposable
    {
        IEscPosCore Begin();
    }
}