namespace CursoOnline.DominioTest.Cursos
{
    public interface ICursoRepositorio
    {
        public void Adicionar(Curso curso);

        public Curso ObterPeloNome(string nome);
    }
}
