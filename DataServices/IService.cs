using DA;
using DC;
using System.Collections.Generic;
using System.ServiceModel;

namespace DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface IService
    {
        string GetLNOxoidByCode(string code);

        List<BonLivraison> GetBonLivraisons();

        string GetQteByIdItemAndIdReception(string idReception, string idItem);

        List<BonLivraisonLigne> GetBonDeLivraisonLigne();

        
        List<BonLivraisonLigne> getCode();

        
        List<BonLivraisonLigne> getLigneBonReceptionById(string id);

        
        List<BonLivraisonLigne> getLBonReception();

        
        List<BonLivraisonLigne> GetBonLivraisonLigneById(string id);

        
        bool UpdateBonLivraisonLigneBy(BonLivraisonLigne bonLigne, string nlot);

        
        List<BonLivraison> GetBonDeLivraisonById(string id);
    
        ArtCode GetArtCode(string artCode);

        
        Article_P GetCodeArticle_P(string code);

        
        List<BonLivraison> getBonReception();

        
        List<BonLivraison> getBonReceptionById(string id);

        
        bool UpdateLivraison(string id);

        
        Articles GetArticles();

        
        List<PieceDivers> GetPieceDivers();

        
        Articles GetCodeArticles(string code);

        
        List<PieceDiversLigne> GetPieceDiversLigneByID(string id);

        
        bool PieceDiversSolded(string id);
        
        bool PieceAchatRecu(string id);

        string SqlTestConnexion(string provider, string serverName, string dataBaseName, string login, string password);

        string SaveConnexionString(string serverName, string dataBaseName, string login, string password);

        string GetCurentSqlServerName();
        string GetCurentSqlDataBase();

        void TestCurrentConnexionString();

        void RecordeItem(Items item);
        // TODO: Add your service operations here
    }
}
