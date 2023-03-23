using DA;
using DC;
using System.Collections.Generic;
using System;

namespace DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {

        private BondeLivraisonLigneDAO bondeLivraisonLigneDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetBondeLivraisonLigneDAO();
        private BondeLivraisonDAO bonLivraisonDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetBonLivraisonDAO();
        private PieceVenteDAO pieceVente_PDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetPieceVente_PDAO();
        private ArtCodeDAO artCodeDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetArtCodeDAO();
        private PieceVenteDAO pieceDeVenteDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetPieceVente_PDAO();
        private Article_PDAO articlePDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetArticle_PDAO();
        private ArticlesDAO articlesDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetArticlesDAO();
        private PieceDiverDAO pieceDiversDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetPieceDiversDAO();
        private PieceDiversLigneDAO pieceDiversLigneDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetPieceDiversLigne();

        private ItemDAO itemDAO = AbstractDAOFactory.GetFactory(FactoryType.ACCES_DAO_FACTORY).GetItemDAO();

        public static void Main()
        {

        }

        public string GetLNOxoidByCode(string code)
        {
            return itemDAO.GetLNOxoidByCode(code);
        }

        public Items RecordeItem(Items item)
        {
            return itemDAO.RecordItem(item);
        }

        public string GetQteByIdItemAndIdReception(string idReception, string idItem)
        {
            return itemDAO.GetQteByIdItemAndIdReception(idReception, idItem);
        }

        public ArtCode GetArtCode(string artCode)
        {
            return artCodeDAO.GetArtCode(artCode);
        }

        public List<BonLivraison> GetBonDeLivraisonById(string id)
        {
            return bonLivraisonDAO.GetBonDeLivraisonById(id);
        }

        public List<BonLivraisonLigne> GetBonDeLivraisonLigne()
        {
            return bondeLivraisonLigneDAO.GetBonDeLivraisonLigne();
        }

        public string GetCurentLoginname()
        {
            return TestConnexion.GetCurentLoginName();
        }

        public List<BonLivraisonLigne> GetBonLivraisonLigneById(string id)
        {
            return bondeLivraisonLigneDAO.GetBonLivraisonLigneById(id);
        }

        public bool UpdateBonReceptionLigneBy(string bonLigne, string nlot)
        {
            return bondeLivraisonLigneDAO.UpdateBonReceptionLigneBy(bonLigne, nlot);
        }

        public List<BonLivraison> GetBonLivraisons()
        {
            return bonLivraisonDAO.GetBonDeLivraison();
        }

        public List<BonLivraison> GetBonReception()
        {
            return bonLivraisonDAO.GetBonReception();
        }

        public List<BonLivraison> GetBonReceptionById(string id)
        {
            return bonLivraisonDAO.GetBonReceptionById(id);
        }

        public List<BonLivraisonLigne> GetCode()
        {
            return bondeLivraisonLigneDAO.GetCode();
        }

        public List<BonLivraisonLigne> GetLBonReception()
        {
            return bondeLivraisonLigneDAO.GetLBonReception();
        }

        public List<BonLivraisonLigne> GetLigneBonReceptionById(string id)
        {
            return bondeLivraisonLigneDAO.GetLigneBonReceptionById(id);
        }

        public bool UpdateLivraison(string id)
        {
            return pieceDeVenteDAO.UpdateLivraison(id);
        }
        public Article_P GetCodeArticle_P(string code)
        {
            return articlePDAO.GetCode(code);
        }

        public Articles GetArticles()
        {
            return articlesDAO.GetArticles();
        }

        public Articles GetCodeArticles(string code)
        {
            return articlesDAO.GetCode(code);
        }

        public List<PieceDivers> GetPieceDivers()
        {
            return pieceDiversDAO.GetPieceDivres();
        }

        public List<PieceDiversLigne> GetPieceDiversLigneByID(string id)
        {
            return pieceDiversLigneDAO.GetPieceVentLigneByID(id);
        }

        public bool PieceDiversSolded(string id)
        {
            return pieceDiversDAO.PieceDiversSolded(id);
        }
        public bool PieceAchatRecu(string id)
        {
            return pieceDiversDAO.PieceAchatRecu(id);
        }

        public bool UpdateBonLivraisonLigneBy(BonLivraisonLigne bonLigne, string nlot)
        {
            throw new NotImplementedException();
        }

        public string SqlTestConnexion(string provider, string serverName, string dataBaseName, string login, string password)
        {
            return TestConnexion.TestConnexionString(provider,serverName, dataBaseName, login, password);
        }

        public string SaveConnexionString(string serverName, string dataBaseName, string login, string password)
        {
            return TestConnexion.SaveConnexionString(serverName, dataBaseName, login, password);
        }

        public string GetCurentSqlServerName()
        {
            return TestConnexion.GetCurentSqlServerName();
        }

        public string GetCurentSqlDataBase()
        {
            return TestConnexion.GetCurentSqlDataBase();
        }

        public void TestCurrentConnexionString()
        {
            TestConnexion.TestCurrentConnexionString();
        }

        List<BonLivraison> IService.GetBonLivraisons()
        {
            throw new NotImplementedException();
        }

        List<BonLivraisonLigne> IService.GetBonDeLivraisonLigne()
        {
            throw new NotImplementedException();
        }

        List<BonLivraisonLigne> IService.getCode()
        {
            throw new NotImplementedException();
        }

        List<BonLivraisonLigne> IService.getLigneBonReceptionById(string id)
        {
            throw new NotImplementedException();
        }

        List<BonLivraisonLigne> IService.getLBonReception()
        {
            throw new NotImplementedException();
        }

        List<BonLivraisonLigne> IService.GetBonLivraisonLigneById(string id)
        {
            throw new NotImplementedException();
        }

        bool IService.UpdateBonLivraisonLigneBy(BonLivraisonLigne bonLigne, string nlot)
        {
            throw new NotImplementedException();
        }

        List<BonLivraison> IService.GetBonDeLivraisonById(string id)
        {
            throw new NotImplementedException();
        }

        ArtCode IService.GetArtCode(string artCode)
        {
            throw new NotImplementedException();
        }

        Article_P IService.GetCodeArticle_P(string code)
        {
            throw new NotImplementedException();
        }

        List<BonLivraison> IService.getBonReception()
        {
            throw new NotImplementedException();
        }

        List<BonLivraison> IService.getBonReceptionById(string id)
        {
            throw new NotImplementedException();
        }

        bool IService.UpdateLivraison(string id)
        {
            throw new NotImplementedException();
        }

        Articles IService.GetArticles()
        {
            throw new NotImplementedException();
        }

        List<PieceDivers> IService.GetPieceDivers()
        {
            throw new NotImplementedException();
        }

        Articles IService.GetCodeArticles(string code)
        {
            throw new NotImplementedException();
        }

        List<PieceDiversLigne> IService.GetPieceDiversLigneByID(string id)
        {
            throw new NotImplementedException();
        }

        bool IService.PieceDiversSolded(string id)
        {
            throw new NotImplementedException();
        }

        bool IService.PieceAchatRecu(string id)
        {
            throw new NotImplementedException();
        }

        string IService.SqlTestConnexion(string provider, string serverName, string dataBaseName, string login, string password)
        {
            throw new NotImplementedException();
        }

        string IService.SaveConnexionString(string serverName, string dataBaseName, string login, string password)
        {
            throw new NotImplementedException();
        }

        string IService.GetCurentSqlServerName()
        {
            throw new NotImplementedException();
        }

        string IService.GetCurentSqlDataBase()
        {
            throw new NotImplementedException();
        }

        void IService.TestCurrentConnexionString()
        {
            throw new NotImplementedException();
        }

        void IService.RecordeItem(Items item)
        {
            throw new NotImplementedException();
        }
    }
}
