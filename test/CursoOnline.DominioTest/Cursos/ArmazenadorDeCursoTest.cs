using Moq;

namespace CursoOnline.DominioTest.Cursos
{
    public class ArmazenadorDeCursoTest
    {
        [Fact]
        public void DeveAdicionarCurso()
        {
            // Asserts
            var cursoDto = new CursoDto
            {
                Nome = "Curso A",
                CargaHoraria = 100,
                PublicoAlvo = 1,
                Valor = 100,
            };

            var cursoRepositorioMock = new Mock<ICursoRepositorio>();
            var armazenadorDeCurso = new ArmazenadorDeCurso(cursoRepositorioMock.Object);

            armazenadorDeCurso.Armazenar(cursoDto);

            cursoRepositorioMock.Verify(r => r.Adicionar(It.IsAny<Curso>()));
        }
    }
}
