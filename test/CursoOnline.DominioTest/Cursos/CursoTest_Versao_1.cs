using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest_Versao_1
    {
        [Fact(DisplayName = "DeveCriarCurso")]
        public void DeveCriarCurso()
        {
            // Arrange
            /*var cursoEsperado = new
            {
                Nome = "Informática",
                CargaHoraria = (double)40,
                PublicoAlvo = "Estudantes",
                Valor = (double)950
            };*/

            /*var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria,
                cursoEsperado.PublicoAlvo, cursoEsperado.Valor);
            */
            // Act

            // Asserts
            //cursoEsperado.ToExpectedObject().ShouldMatch(curso);
            
        }
    }

}
