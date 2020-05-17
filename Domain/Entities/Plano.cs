namespace Domain
{
    public class Plano
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int DDD { get; set; }
        public int Minutos { get; set; }
        public int Franquia { get; set; }
        public double Valor { get; set; }
        public TipoPlanoEnum Tipo { get; set; }
        public Operadora Operadora { get; set; }
        public bool Disponibilidade { get; set; }
    }
}
