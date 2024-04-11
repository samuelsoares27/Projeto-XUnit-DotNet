namespace CursoOnline.DominioTest
{
    public class Curso
    {
        public string Nome { get; internal set; }
        public double CargaHoraria { get; internal set; }
        public PublicoAlvo PublicoAlvo { get; internal set; }
        public double Valor { get; internal set; }
        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome inválido");

            if (cargaHoraria < 1.0)
                throw new ArgumentException("Carga Horária inválida");

            if (valor <= 1.0)
                throw new ArgumentException("Valor inválido");

            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
            this.Valor = valor;
        }

    }
}
