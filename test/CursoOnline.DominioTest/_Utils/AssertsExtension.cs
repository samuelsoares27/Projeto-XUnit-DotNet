namespace CursoOnline.DominioTest._Utils
{
    public static class AssertsExtension
    {
        public static void ComMensagem(this ArgumentException exception, string mensagem)
        {
            if (exception.Message == mensagem) 
                Assert.True(true);
            else 
                Assert.False(false, $"Esperava a mensagem {mensagem}");
        }
    }
}
