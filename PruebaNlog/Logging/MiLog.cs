using System;
using NLog;

namespace PruebaNlog.Logging
{
    public class MiLog<T> : IMiLog
    {
        private static readonly ILogger Logger = LogManager.GetLogger(typeof(T).FullName);

        private readonly IContexto _contexto;

        public MiLog(IContexto contexto)
        {
            _contexto = contexto;
        }

        public void Info(string mensaje)
        {
            Logger.Log(LogLevel.Info, mensaje);
            Console.WriteLine(mensaje + ": " + _contexto.Nombre);
        }
    }
}
