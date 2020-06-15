using DatabaseLayer.Interfaces;

namespace BusinessLayer
{
    public interface IUnitOfWork
    {
        IZaposlenikRepository Zaposlenici { get; set; }
        IKategorijaArtiklaRepository KategorijaArtikla { get; set; }
        IArtiklRepository Artikli { get; set; }
        IDobavljacRepository Dobavljaci { get; set; }

        int Complete();
    }
}