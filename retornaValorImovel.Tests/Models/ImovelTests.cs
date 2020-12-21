using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using retornaValorImovel.Models;

namespace retornaValorImovel.Tests.Models
{
    [TestClass]
    public class ImovelTests
    {
        [TestMethod]
        [TestCategory("Model")]
        public void Dado_um_novo_imovel_verifica_seu_valor_total()
        {
            var imovel = new Imovel();
            imovel.qtdeM2 = 50;
            imovel.valorM2 = 4000;
            Assert.AreEqual(imovel.valorTotal, imovel.qtdeM2 * imovel.valorM2);
        }

    }
}