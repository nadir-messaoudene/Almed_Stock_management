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
        private ArtCodeDAO ArtCodeDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetArtCodeDAO();
        private PieceVenteDAO pieceDeVenteDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetPieceVente_PDAO();
        private Article_PDAO articlePDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetArticle_PDAO();
        private ArticlesDAO articlesDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetArticlesDAO();
        private PieceDiverDAO pieceDiversDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetPieceDiversDAO();
        private PieceDiversLigneDAO pieceDiversLigneDAO = AbstractDAOFactory.GetFactory(FactoryType.SQL_DAO_FACTORY).GetPieceDiversLigne();

        static void Main(string[] args)
        {
        }

        public ArtCode GetArtCode(string artCode)
        {
            return ArtCodeDAO.GetArtCode(artCode);
        }

        public List<BonLivraison> GetBonDeLivraisonById(string id)
        {
            return bonLivraisonDAO.GetBonDeLivraisonById(id);
        }

        public List<BonLivraisonLigne> GetBonDeLivraisonLigne()
        {
            return bondeLivraisonLigneDAO.GetBonDeLivraisonLigne();
        }

        public List<BonLivraisonLigne> GetBonLivraisonLigneById(string id)
        {
            return bondeLivraisonLigneDAO.GetBonLivraisonLigneById(id);
        }

        public bool UpdateBonLivraisonLigneBy(string bonLigne, string nlot)
        {
            return bondeLivraisonLigneDAO.UpdateBonLivraisonLigneBy(bonLigne, nlot);
        }

        public List<BonLivraison> GetBonLivraisons()
        {
            return bonLivraisonDAO.GetBonDeLivraison();
        }

        public List<BonLivraison> getBonReception()
        {
            return bonLivraisonDAO.getBonReception();
        }

        public List<BonLivraison> getBonReceptionById(string id)
        {
            return bonLivraisonDAO.getBonReceptionById(id);
        }

        public List<BonLivraisonLigne> getCode()
        {
            return bondeLivraisonLigneDAO.getCode();
        }
        [Obsolete("methode depricated, please use GetCodeArticle_P()")]
        public Article_P GetCode(string code)
        {
            return articlePDAO.GetCode(code);
        }

        public List<BonLivraisonLigne> getLBonReception()
        {
            return bondeLivraisonLigneDAO.getLBonReception();
        }

        public List<BonLivraisonLigne> getLigneBonReceptionById(string id)
        {
            return bondeLivraisonLigneDAO.getLigneBonReceptionById(id);
        }

        public bool update(string id)
        {
            return pieceDeVenteDAO.update(id);
        }

        public PieceVente_P Update(PieceVente_P pieceVent_P)
        {
            throw new NotImplementedException();
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
    }
}
