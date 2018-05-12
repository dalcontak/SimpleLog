using PruebaNlog.Logging;

namespace PruebaNlog.usos
{
    public class ConsumidorUno
    {
        private readonly IMiLog _log;

        public ConsumidorUno(IMiLog log)
        {
            _log = log;
        }

        public void Saludo()
        {
            _log.Info("Adios");
        }
    }
}
