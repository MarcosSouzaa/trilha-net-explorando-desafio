namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        // Criando uma coleção de hospedes do tipo Pessoa
        // Tipo Pessoa tem Nome, SobreNome e NomeCompleto
        public List<Pessoa> Hospedes { get; set; }

        // Tipo Suite tem TipoSuite, Capacidade e ValorDiaria
        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido            
            if ( Suite.Capacidade >= hospedes.Count) 
                       {
                Hospedes = hospedes;               
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Capacidade da Suite menor que o nº de hospedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)             
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor -= Decimal.Divide(Decimal.Multiply(valor,10),100);
            }

            return valor;
        }
    }
}