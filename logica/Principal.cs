using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Principal
    {
        List<Persona> personas = new List<Persona>();
        List<Cobertura> coberturas = new List<Cobertura>();
        public Persona BuscarPersonaPorDNI(int DNI)
        {
            foreach (var item in personas)
            {
                if (item.DNI == DNI)
                    return item;
            }
            return null;
        }
        public bool PuedeAcceder(Cobertura cobertura, int DNI)
        {
            Persona PersonaEncontrada = BuscarPersonaPorDNI(DNI);
            if (cobertura.CostoBase <= PersonaEncontrada.IngresosNetos)
                return true;
            return false;
        }


        public decimal RegistrarAtencion(int DNI, string tipo, Cobertura cobertura)
        {
            int Autoincr = 0;
            bool Valido = cobertura.EsValidoParaAtenciones(tipo);
            if (Valido == true)
            {
                Autoincr += 1;
                DateTime fechaAtencion = DateTime.Today;
                Atencion nuevaAtencion = new Atencion();
                string TipoAtendido = nuevaAtencion.EnfermedadAtendida.Tipo;
                string NombreAtendido = nuevaAtencion.EnfermedadAtendida.Nombre;
                decimal CostoEnfermedad = nuevaAtencion.EnfermedadAtendida.Costo;
                string NombrePersonaAtendida = nuevaAtencion.PacienteAtendido.NombreApellido;
                new EmailManager()
                .From("from@sebys.com.ar")
                .To("mati.delbono00@gmail.com.ar")
                .Subject("envio Mail carga correcta")
                .Body("la atencion se cargo correctamente")
                .Send();
                return CostoEnfermedad;


            }
            return 0;
        }

        public sealed class Singleton
        {
            private static Singleton instance = null;
            private Singleton()
            {

            }
            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();

                    }
                    return instance;
                }

            }
        }
        public class EmailManager
        {
            private string from { get; set; }
            private string to { get; set; }
            private string subject { get; set; }
            private string body { get; set; }
            public EmailManager From(string from)
            {
                this.from = from;
                return this;
            }
            public EmailManager To(string to)
            {
                this.to = to;
                return this;
            }
            public EmailManager Subject(string subject)
            {
                this.subject = subject;
                return this;
            }
            public EmailManager Body(string body)
            {
                this.body = body;
                return this;
            }
            public void Send()
            {
                //Enviar correo
            }
        }
    }
}
    

