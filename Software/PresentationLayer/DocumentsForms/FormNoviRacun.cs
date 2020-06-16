using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repositories;
using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;

namespace PresentationLayer.DocumentsForms
{
    public partial class FormNoviRacun : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        private ICollection<StavkaRacuna> stavkeRacuna;
        private Racun racun = new Racun();
        StavkaRacuna stavkaRacuna;
        double osnovica = 0;
        public FormNoviRacun()
        {
            InitializeComponent();
            racun = new Racun
            {
                DatumIVrijemeIzdavanja = DateTime.Now,
            };
        }

        private void FormNoviRacun_Load(object sender, EventArgs e)
        {
            DohvatiArtikle();
            stavkeRacuna = new List<StavkaRacuna>();
            
            unitOfWork.Racuni.Add(racun);
            unitOfWork.Complete();
        }

        private void DohvatiArtikle()
        {
            cmbArtikl.DataSource = unitOfWork.Artikli.GetAll();
            cmbArtikl.DisplayMember = "Naziv";
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            stavkaRacuna = new StavkaRacuna();
            stavkaRacuna.Artikl = cmbArtikl.SelectedItem as Artikl;
            stavkaRacuna.Racun = racun;
            stavkaRacuna.RacunId = racun.Id;
            stavkaRacuna.ArtiklId = (cmbArtikl.SelectedItem as Artikl).Id;
            stavkaRacuna.Kolicina = int.Parse(tboKolicina.Text);
            stavkeRacuna.Add(stavkaRacuna);
            OsvjeziDgv();
            OsvjeziIznose();
        }

        private void OsvjeziIznose()
        {
            osnovica += (cmbArtikl.SelectedItem as Artikl).Cijena * int.Parse(tboKolicina.Text);
            tboOsnovica.Text = osnovica.ToString();
            tboPorezNaPotrosnju.Text = IzracunajPorezNaPotrosnju(osnovica).ToString();
            tboPorezNaDodanuVrijednost.Text = IzracunajPorezNaDodanuVrijednost(osnovica).ToString();
            tboUkupno.Text = IzracunajUkupno(osnovica).ToString();
        }

        private double IzracunajUkupno(double osnovica)
        {
            double ukupno = osnovica + IzracunajPorezNaPotrosnju(osnovica) + IzracunajPorezNaDodanuVrijednost(osnovica);
            return ukupno;
        }

        private double IzracunajPorezNaDodanuVrijednost(double osnovica)
        {
            double pdv = (0.25 * osnovica);
            return pdv;
        }

        private double IzracunajPorezNaPotrosnju(double osnovica)
        {
            double pnp = (0.03 * osnovica);
            return pnp;
        }

        private void OsvjeziDgv()
        {
            dgvStavkeRacuna.DataSource = null;
            dgvStavkeRacuna.DataSource = stavkeRacuna.ToList();
            dgvStavkeRacuna.Columns["Racun"].Visible = false;
            dgvStavkeRacuna.Columns["RacunId"].Visible = false;
            //dgvStavkeRacuna.Columns["ArtiklId"].Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            unitOfWork.Racuni.Delete(racun);
            this.Close();
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in stavkeRacuna)
                {
                    unitOfWork.StavkeRacuna.Add(item);
                    unitOfWork.Complete();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ne mozete imati isti artikl više puta na računu!");
            }
            this.Close();
        }
    }
}
