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
            Enum.TryParse(typeof(PublicoAlvo), cursoDto.PublicoAlvo, out var publicoAlvo);

            if(publicoAlvo == null)             
                throw new ArgumentException();
            

            var curso = new Curso(cursoDto.Nome, cursoDto.CargaHoraria, (PublicoAlvo)publicoAlvo, cursoDto.Valor);

            _cursoRepositorio.Adicionar(curso);
        }
    }
}