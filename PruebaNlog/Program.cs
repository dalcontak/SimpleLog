using PruebaNlog.Logging;
using PruebaNlog.usos;
using SimpleInjector;

namespace PruebaNlog
{
    class Program
    {
        private static readonly Container container;

        static Program()
        {
            container = new Container();

            container.Register<IContexto,Contexto>(Lifestyle.Singleton);
            container.RegisterConditional(
                typeof(IMiLog),
                c => typeof(MiLog<>).MakeGenericType(c.Consumer.ImplementationType),
                Lifestyle.Singleton,
                container => true);

            container.Register<ConsumidorUno>();
            container.Register<ConsumidorDos>();

            container.Verify();
        }

        static void Main(string[] args)
        {
            var consumidor = container.GetInstance<ConsumidorUno>();

            consumidor.Saludo();

            var otro = container.GetInstance<ConsumidorDos>();

            otro.Saludo();
        }
    }
}
