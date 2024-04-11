using CursoOnline.DominioTest._Utils;
using ExpectedObjects;
using Xunit.Abstractions;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest_Versao_3
    {
        private readonly ITestOutputHelper _output;
        private readonly string _nome;
        private readonly double _cargaHoraria;
        private readonly PublicoAlvo _publicoAlvo;
        private readonly double _valor;

        public CursoTest_Versao_3(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Construtor sendo Executado");

            _nome = "Informática";
            _cargaHoraria = (double)40;
            _publicoAlvo = PublicoAlvo.Estudante;
            _valor = (double)950;
        }

        [Fact(DisplayName = "DeveCriarCurso")]
        public void DeveCriarCurso()
        {
            // Arrange
            var cursoEsperado = new
            {
                Nome = _nome,
                CargaHoraria = _cargaHoraria,
                PublicoAlvo = _publicoAlvo,
                Valor = _valor
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

            // Asserts
            Assert.Throws<ArgumentException>(() => 
            new Curso(nomeInvalido, _cargaHoraria, _publicoAlvo, _valor))
                .ComMensagem("Nome inválido");            
            
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void NaoDeveTerUmaCargaHorariaInvalida(double cargaHorariaInvalidade)
        {
            // Asserts
            Assert.Throws<ArgumentException>(() =>
            new Curso(_nome, cargaHorariaInvalidade, _publicoAlvo, _valor))
                .ComMensagem("Carga Horária inválida");

        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void NaoDeveTerUmValorInvalido(double valorInvalido)
        {
            // Asserts
            Assert.Throws<ArgumentException>(() =>
            new Curso(_nome, _cargaHoraria, _publicoAlvo, valorInvalido))
                .ComMensagem("Valor inválido");

        }


    }


}
