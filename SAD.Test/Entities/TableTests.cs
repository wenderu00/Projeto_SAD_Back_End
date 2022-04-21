using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Test.Entities
{
    [TestClass]
    public class TableTests
    {
        private readonly Projeto _projeto1 = new Projeto("Projeto 1", 3, 1, 1, 1, 0, 18, 120, 10000);
        private readonly Projeto _projeto2 = new Projeto("Projeto 2", 3, 3, 3, 1, 0, 27, 365, 90000);
        private readonly Projeto _projeto3 = new Projeto("Projeto 3", 4, 3, 3, 1, 0, 27, 120, 30000);
        private readonly Projeto _projeto4 = new Projeto("Projeto 4", 2, 4, 1, 1, 0, 24, 200, 35000);
        private readonly Projeto _projeto5 = new Projeto("Projeto 5", 2, 4, 2, 1, 0, 24, 200, 40000);
        private readonly Projeto _projeto6 = new Projeto("Projeto 6", 5, 3, 1, 1, 0, 27, 120, 90000);
        private readonly Projeto _projeto7 = new Projeto("Projeto 7", 3, 1, 1, 1, 0, 3, 400, 20000);
        private readonly Projeto _projeto8 = new Projeto("Projeto 8", 3, 4, 3, 1, 0, 27, 120, 20000);
        private readonly Projeto _projeto9 = new Projeto("Projeto 9", 3, 1, 1, 1, 0, 27, 420, 80000);
        private readonly Projeto _projeto10 = new Projeto("Projeto 10", 2, 1, 1, 1, 0, 27, 120, 60000);
        private readonly Projeto _projeto11 = new Projeto("Projeto 11", 1, 1, 1, 1, 0, 27, 120, 70000);
        private readonly Projeto _projeto12 = new Projeto("Projeto 12", 2, 3, 1, 1, 0, 8, 150, 45000);
        private readonly Projeto _projeto13 = new Projeto("Projeto 13", 5, 5, 3, 1, 0, 48, 200, 80000);
        private readonly Projeto _projeto14 = new Projeto("Projeto 14", 3, 3, 3, 1, 0, 36, 120, 50000);
        private readonly Projeto _projeto15 = new Projeto("Projeto 15", 5, 3, 2, 1, 1, 125, 120, 200000);
        private readonly Tabela _tabela;
        private IList<Projeto> _projetos = new List<Projeto>();
        public TableTests()
        {
            _projetos.Add(_projeto1);
            _projetos.Add(_projeto2);
            _projetos.Add(_projeto3);
            _projetos.Add(_projeto4);
            _projetos.Add(_projeto5);
            _projetos.Add(_projeto6);
            _projetos.Add(_projeto7);
            _projetos.Add(_projeto8);
            _projetos.Add(_projeto9);
            _projetos.Add(_projeto10);
            _projetos.Add(_projeto11);
            _projetos.Add(_projeto12);
            _projetos.Add(_projeto13);
            _projetos.Add(_projeto14);
            _projetos.Add(_projeto15);
            _tabela = new Tabela(_projetos);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_A_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioA, 12.72792206);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_B_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioB, 12.72792206);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_C_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioC, 12.72792206);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_D_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioD, 12.72792206);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_E_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioE, 12.72792206);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_F_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioF, 12.72792206);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_G_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioG, 12.72792206);
        }
        [TestMethod]
        public void apos_a_criacao_deve_obter_a_propriedade_normalizacao_criterio_H_valida()
        {
            Assert.AreEqual(_tabela.Normalizacao.CriterioH, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_A_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioA, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_B_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioB, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_C_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioC, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_D_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioD, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_E_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioE, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_F_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioF, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_G_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioG, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_positiva_criterio_H_valida()
        {
            Assert.AreEqual(_tabela.IdealPositiva.CriterioH, 12.72792206);
        }
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_A_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioA, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_B_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioB, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_C_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioC, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_D_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioD, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_E_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioE, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_F_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioF, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_G_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioG, 12.72792206);
        }
        [TestMethod]
        public void apos_a_normalizacao_obter_a_propriedade_ideal_negativa_criterio_H_valida()
        {
            Assert.AreEqual(_tabela.IdealNegativa.CriterioH, 12.72792206);
        }
        

    }
}
