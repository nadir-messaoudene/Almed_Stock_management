using DC;
using System;

namespace DA
{
    public class DAOFactory : AbstractDAOFactory
    {

        //TODO : Add a data scces method ...
        //...
        public override ArtCodeDAO GetArtCodeDAO()
        {
            return new ArtCodeDAO();
        }

        public override ArticlesDAO GetArticlesDAO()
        {
            return new ArticlesDAO();
        }

        public override Article_PDAO GetArticle_PDAO()
        {
            return new Article_PDAO();
        }

        public override BondeLivraisonLigneDAO GetBondeLivraisonLigneDAO()
        {
            return new BondeLivraisonLigneDAO();
        }

        public override BondeLivraisonDAO GetBonLivraisonDAO()
        {
            return new BondeLivraisonDAO();
        }

        public override PieceDiverDAO GetPieceDiversDAO()
        {
           return new PieceDiverDAO();
        }

        public override PieceDiversLigneDAO GetPieceDiversLigne()
        {
            return new PieceDiversLigneDAO();
        }

        public override PieceVenteDAO GetPieceVente_PDAO()
        {
            return new PieceVenteDAO();
        }
    }
}
