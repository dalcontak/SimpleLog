using PruebaNlog.Logging;

namespace PruebaNlog.usos
{
    public class ConsumidorDos
    {
        private readonly IMiLog _log;

        public ConsumidorDos(IMiLog log)
        {
            _log = log;
        }

        public void Saludo()
        {
            _log.Info("Hola");
        }
    }
}
