using System;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones__1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carga de atenciones
            Console.WriteLine("Cargue el DNI ");
            int DNI = int.Parse(Console.ReadLine());
            while (DNI!=0)
            {
                Console.WriteLine("Cargue el tipo de enfermedad ");
                string tipo=(Console.ReadLine());
                Console.WriteLine("Cargue el Nombre de enfermedad ");
                string NombreEnfermedad = (Console.ReadLine());
                Console.WriteLine("Cargue el costo de enfermedad ");
                decimal Costo = decimal.Parse((Console.ReadLine()));
                Console.WriteLine("Cargue el nombre del paciente");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Cargue el DNI ");
                DNI= int.Parse(Console.ReadLine());
            }

            {
                Console.WriteLine("Mail To");
                MailAddress to = new MailAddress(Console.ReadLine());

                Console.WriteLine("Mail From");
                MailAddress from = new MailAddress(Console.ReadLine());

                MailMessage mail = new MailMessage(from, to);

                Console.WriteLine("Subject");
                mail.Subject = Console.ReadLine();

                Console.WriteLine("Your Message");
                mail.Body = Console.ReadLine();

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                smtp.Credentials = new NetworkCredential(
                    "username@domain.com", "password");
                smtp.EnableSsl = true;
                Console.WriteLine("Sending email...");
                smtp.Send(mail);
            }




        }
}
}