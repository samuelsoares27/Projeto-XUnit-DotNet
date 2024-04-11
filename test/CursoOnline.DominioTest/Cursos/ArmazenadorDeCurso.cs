namespace CursoOnline.DominioTest.Cursos
{
    public class ArmazenadorDeCurso
    {
        private readonly ICursoRepositorio _cursoRepositorio;
        public ArmazenadorDeCurso() { }
        public ArmazenadorDeCurso(ICursoRepositorio cursoRepositorio) {
            _cursoRepositorio = cursoRepositorio;
        }
        public void Armazenar(CursoDto cursoDto)
        {
            var curso = new Curso(cursoDto.Nome, cursoDto.CargaHoraria, PublicoAlvo.Empregado, cursoDto.Valor);

            _cursoRepositorio.Adicionar(curso);
        }
    }
}