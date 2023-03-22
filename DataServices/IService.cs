using DC;
using System.Collections.Generic;
using System.ServiceModel;

namespace DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<BonLivraison> GetBonLivraisons();

        [OperationContract]
        List<BonLivraisonLigne> GetBonDeLivraisonLigne();

        [OperationContract]
        List<BonLivraisonLigne> getCode();

        [OperationContract]
        List<BonLivraisonLigne> getLigneBonReceptionById(string id);

        [OperationContract]
        List<BonLivraisonLigne> getLBonReception();

        [OperationContract]
        List<BonLivraisonLigne> GetBonLivraisonLigneById(string id);

        [OperationContract]
        bool UpdateBonLivraisonLigneBy(BonLivraisonLigne bonLigne, string nlot);

        [OperationContract]
        List<BonLivraison> GetBonDeLivraisonById(string id);

        [OperationContract]
        PieceVente_P Update(PieceVente_P pieceVent_P);

        [OperationContract]
        ArtCode GetArtCode(string artCode);

        [OperationContract]
        Article_P GetCodeArticle_P(string code);

        [OperationContract]
        List<BonLivraison> getBonReception();

        [OperationContract]
        List<BonLivraison> getBonReceptionById(string id);

        [OperationContract]
        bool update(string id);

        [OperationContract]
        Articles GetArticles();

        [OperationContract]
        List<PieceDivers> GetPieceDivers();

        [OperationContract]
        Articles GetCodeArticles(string code);

        [OperationContract]
        List<PieceDiversLigne> GetPieceDiversLigneByID(string id);

        [OperationContract]
        bool PieceDiversSolded(string id);
        [OperationContract]
        bool PieceAchatRecu(string id);
        // TODO: Add your service operations here
    }
}
