using DatabaseLayer.Interfaces;

namespace BusinessLayer
{
    public interface IUnitOfWork
    {
        IZaposlenikRepository Zaposlenici { get; set; }

        int Complete();
    }
}