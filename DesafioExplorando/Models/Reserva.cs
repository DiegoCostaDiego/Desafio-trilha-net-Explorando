using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioExplorando.Models
{
    
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
          
            if (Suite.Capacidade <= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
               
                throw new Exception("Capacidade do quarto menor que o número de hóspedes recebidos.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
     
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
     
            decimal valor = DiasReservados * Suite.ValorDiaria;

          
            if (DiasReservados >= 10)
            {
               decimal valorTotal = DiasReservados * Suite.ValorDiaria;
               decimal desconto = 0.9M;
               valor = valorTotal * desconto; 
            }

            return valor;
        }
    }
}
