namespace DesafioProjetoHospedagem.Models
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

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {

             throw new ArgumentException("Error - A quantidade de hospedes não pode exceder a capacidade da suíte!!");

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
        
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                decimal valorDesconto = valorDiaria * 10/100;
                valorDiaria -= valorDesconto;
            }

            return valorDiaria;
        }
    }
}