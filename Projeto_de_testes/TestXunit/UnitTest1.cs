using Projeto_de_testes;

namespace TestXunit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);

        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 3)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }
    }
}