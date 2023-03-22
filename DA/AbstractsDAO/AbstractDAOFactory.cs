using DC;
namespace DA
{
    public abstract class AbstractDAOFactory
    {

        public static AbstractDAOFactory GetFactory(FactoryType type)
        {
            if (type.Equals(FactoryType.SQL_DAO_FACTORY))
                return new DAOFactory();


            //add different type of connection
            //...

            return null;
        }
        public abstract BondeLivraisonLigneDAO GetBondeLivraisonLigneDAO();
        public abstract BondeLivraisonDAO GetBonLivraisonDAO();
        public abstract PieceVenteDAO GetPieceVente_PDAO();
        public abstract ArtCodeDAO GetArtCodeDAO();
        public abstract Article_PDAO GetArticle_PDAO();
        public abstract ArticlesDAO GetArticlesDAO();
        public abstract PieceDiverDAO GetPieceDiversDAO();
        public abstract PieceDiversLigneDAO GetPieceDiversLigne();
    }
}
