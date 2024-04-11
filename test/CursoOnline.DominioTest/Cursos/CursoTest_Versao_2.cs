using CursoOnline.DominioTest._Utils;
using ExpectedObjects;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest_Versao_2
    {
        [Fact(DisplayName = "DeveCriarCurso")]
        public void DeveCriarCurso()
        {
            // Arrange
            var cursoEsperado = new
            {
                Nome = "Informática",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)950
            };

            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria,
                cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

            // Act

            // Asserts
            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
            
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCursoTerUmNomeInvalido(string nomeInvalido)
        {

            // Arrange
            var cursoEsperado = new
            {
                Nome = nomeInvalido,
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)950
            };

            // Asserts
            Assert.Throws<ArgumentException>(() => 
            new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria,
                cursoEsperado.PublicoAlvo, cursoEsperado.Valor))
                .ComMensagem("Nome inválido");            
            
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void NaoDeveTerUmaCargaHorariaInvalida(double cargaHorariaInvalidade)
        {
            // Arrange
            var cursoEsperado = new
            {
                Nome = "Informática",
                CargaHoraria = cargaHorariaInvalidade,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)950
            };

            // Asserts
            Assert.Throws<ArgumentException>(() =>
            new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria,
                cursoEsperado.PublicoAlvo, cursoEsperado.Valor))
                .ComMensagem("Carga Horária inválida");

        }


        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void NaoDeveTerUmValorInvalido(double valorInvalido)
        {
            // Arrange
            var cursoEsperado = new
            {
                Nome = "Informática",
                CargaHoraria = (double)100,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)valorInvalido
            };

            // Asserts
            Assert.Throws<ArgumentException>(() =>
            new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria,
                cursoEsperado.PublicoAlvo, valorInvalido))
                .ComMensagem("Valor inválido");

        }
    }


}
