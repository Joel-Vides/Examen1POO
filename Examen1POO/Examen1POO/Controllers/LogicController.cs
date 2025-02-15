using System.Security.Cryptography.X509Certificates;
using Examen1POO.List;
using Microsoft.AspNetCore.Mvc;

namespace Examen1POO.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class LogicController : ControllerBase
    {

        [HttpGet("is-prime/{numero}")]

        public IActionResult Prime(int numero)
        {
            Console.WriteLine("Ingresar un Número");

            for (int i = 0; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine("El Número es Primo");
                    break;
                }
                else
                {
                    Console.WriteLine("El Número no es Primo");
                }
            }

            return numero;
        }
        //public int NumeroPrimo()
        //{


        //}

        [HttpGet]
        [Route("api/factorial")]
        public int NumeroEntero()
        {
            Console.WriteLine("Ingresar un Número");
            int numerofact = int.Parse(Console.ReadLine());
            int resultado = 0;
            for (int i = 1; i <= numerofact; i++)
            {
                resultado += numerofact * i;
            }
            return resultado;
        }


        [HttpGet]
        [Route("api/fibonacci")]
        public IActionResult NumeroFibonacci(int numerofib)
        {
            int numero1 = 0;
            int numero2 = 1;
            int numeros[];

            for (int i = 0; i < numerofib; i++)
            {

                numero1 = numero1 + numero2;
                numeros[i] = numero1;
                for (int j = i; j < numerofib; j++)
                {
                    numero2 = numero2 + numero1;
                    numeros[j] = numero2;
                }

            }
            return 0;
        }

        [HttpGet("count-vowels")]
        public IActionResult Vocales() 
        {

            return Vocales();
        }
    }
}
