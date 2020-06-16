using DatabaseLayer.Interfaces;

namespace BusinessLayer
{
    public interface IUnitOfWork
    {
        IZaposlenikRepository Zaposlenici { get; set; }
        IKategorijaArtiklaRepository KategorijaArtikla { get; set; }
        IArtiklRepository Artikli { get; set; }
        IDobavljacRepository Dobavljaci { get; set; }
        IRacunRepository Racuni { get; set; }
        IStavkaRacuna StavkeRacuna { get; set; }
        int Complete();
    }
}