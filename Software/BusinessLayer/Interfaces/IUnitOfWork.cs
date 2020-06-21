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
        IPrimkaRepository Primke { get; set; }
        IStavkaPrimke StavkePrimke { get; set; }
        IUlogaRepository Uloge { get; set; }
        INarudzbenica Narudzbenica { get; set; }
        IStavkaNarudzbenice StavkaNarudzbenice { get; set; }
        int Complete();
    }
}