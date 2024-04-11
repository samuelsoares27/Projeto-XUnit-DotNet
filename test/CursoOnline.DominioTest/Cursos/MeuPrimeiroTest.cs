namespace CursoOnline.DominioTest.Cursos
{
    public class MeuPrimeiroTest
    {
        [Fact(DisplayName = "testar")]
        public void DeveAsVariaveisTeremOMesmoValor()
        {
            // Arrange
            var variavel1 = 1;
            var variavel2 = 1;

            // Act

            // Asserts
            Assert.True(variavel1 == variavel2);
        }
    }
}