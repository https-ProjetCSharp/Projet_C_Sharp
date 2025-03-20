using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_ecole
{
    public partial class FormRapportEtudiants : Form
    {
        ReportDocument reportDocument = new ReportDocument();
        public FormRapportEtudiants()
        {
            InitializeComponent();
        }

        private void FormRapportEtudiants_Load(object sender, EventArgs e)
        {
            try
            {
                reportDocument.Load(@"C:\Users\Lenovo T470s\Documents\Projet_C_Sharp\Gestion d'ecole\etudiants.rpt"); // Mets le bon chemin
                crystalReportViewer1.ReportSource = reportDocument;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du rapport : " + ex.Message);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Fichier PDF (*.pdf)|*.pdf",
                    Title = "Enregistrer le fichier PDF"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog.FileName);
                    MessageBox.Show("Le rapport a été exporté en PDF avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation en PDF : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Fichier Excel (*.xls)|*.xls",
                    Title = "Enregistrer le fichier Excel"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    reportDocument.ExportToDisk(ExportFormatType.Excel, saveFileDialog.FileName);
                    MessageBox.Show("Le rapport a été exporté en Excel avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation en Excel : " + ex.Message);
            }
        }
    }
}
