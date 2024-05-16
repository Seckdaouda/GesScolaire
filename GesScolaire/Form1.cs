using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GesScolaire
{
    public partial class Form1 : Form
    {
        GesscolaireEntities2 context = new GesscolaireEntities2();
        public Form1()
        {
            InitializeComponent();
            dataGridViewClasse.DataSource = context.Classe.ToList();
            // dataGridViewEtudiant.DataSource = context.Etudiant.ToList();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void saveclasse_Click(object sender, EventArgs e)
        {
            Classe c = new Classe();
            c.libelle = comboNiveau.Text + comboSpecialite.Text;
            c.niveau = comboNiveau.Text;
            c.specialite = comboSpecialite.Text;
            context.Classe.Add(c);
            context.SaveChanges();
            MessageBox.Show("Ajout réussie...");
            dataGridViewClasse.DataSource = context.Classe.ToList();             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant();
            et.prenom = textprenom.Text;
            et.nom = textnom.Text;
            et.credit = int.Parse(textcredit.Text);
            
            DateTime annee;
            if (DateTime.TryParse(dateTimeAnneescolaire.Text, out annee))
            {
                et.anneescolaire = annee.Year;
            }

            et.montantverser = int.Parse(textMontant.Text);
            et.idclasse = Convert.ToInt32(comboClasse.SelectedValue);
            context.Etudiant.Add(et);
            context.SaveChanges();
            MessageBox.Show("Ajout réussie...");
            rechargerDatagridviewEtudiant();
        }
        private void remplirecomboclasse(object sender, EventArgs e)
        {
            comboClasse.DataSource = context.Classe.ToList();
            comboClasse.DisplayMember = "libelle";
            comboClasse.ValueMember = "id";
        }
       private void rechargerDatagridviewEtudiant()
        {
            var etudiantsAvecClasse = (from etu in context.Etudiant
                                       join cl in context.Classe on etu.idclasse equals cl.id
                                       select new
                                       {
                                           etu.id,
                                           etu.prenom,
                                           etu.nom,
                                           etu.anneescolaire,
                                           etu.montantverser,
                                           etu.credit,
                                       
                                           Classe = cl.libelle
                                       }).ToList();

            // Afficher les étudiants avec les détails de la classe dans le DataGridView
            dataGridViewEtudiant.DataSource = etudiantsAvecClasse;
        }
        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                remplirecomboclasse(sender, e);
            rechargerDatagridviewEtudiant();
        }

        private void recherche_Click(object sender, EventArgs e)
        {
            
            string libelleClasse = textRechercher.Text;
            // string anneeScolaire = Convert.ToInt32(textRechercher.Text);

            int idClasse = context.Classe
                       .Where(cl => cl.libelle == libelleClasse)
                       .Select(cl => cl.id)
                       .FirstOrDefault();

            if (idClasse != 0)
            {
              
                var etudiants = context.Etudiant
                                        .Where(et => et.idclasse == idClasse)
                                        .ToList();

           
                dataGridViewEtudiant.DataSource = etudiants;
            }
            else
            {
                MessageBox.Show("Classe non trouvée !");
            }


        }

        private void dataGridViewEtudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEtudiant.Rows[e.RowIndex];
                string id= row.Cells["id"].Value.ToString();
                string prenom = row.Cells["prenom"].Value.ToString();
                string nom = row.Cells["nom"].Value.ToString();
                string credit = row.Cells["credit"].Value.ToString();
                string montantVerse = row.Cells["montantverser"].Value.ToString();
                string classe = row.Cells["classe"].Value.ToString();
              //  string annee = row.Cells["AnneeColumnName"].Value.ToString();
                 
                textIdEtudiant.Text = id;
                textprenom.Text = prenom;
                textnom.Text = nom;
                textcredit.Text = credit;
                textMontant.Text = montantVerse;
               comboClasse.Text = classe;
               // annee.Text = annee;
            }
        }

        private void effacher_Click(object sender, EventArgs e)
        {
            textIdEtudiant.Text = "";
            textprenom.Text = "";
            textnom.Text = "";
            textcredit.Text = "";
            textMontant.Text = "";
            comboClasse.SelectedIndex = 0;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
       
            int idEtudiant = int.Parse(textIdEtudiant.Text);
            Etudiant etudiant = context.Etudiant.FirstOrDefault(et => et.id == idEtudiant);

            if (etudiant != null)
            {
                etudiant.prenom = textprenom.Text;
                etudiant.nom = textnom.Text;
                etudiant.credit = int.Parse(textcredit.Text);

                DateTime annee;
                if (DateTime.TryParse(dateTimeAnneescolaire.Text, out annee))
                {
                    etudiant.anneescolaire = annee.Year;
                }

                etudiant.montantverser = int.Parse(textMontant.Text);
                etudiant.idclasse = Convert.ToInt32(comboClasse.SelectedValue);

                context.SaveChanges();

                dataGridViewEtudiant.DataSource = context.Etudiant.ToList();

                MessageBox.Show("Modification réussie !");
            }
            else
            {
                MessageBox.Show("Étudiant non trouvé !");
            }

        }

        private void modifierclasse_Click(object sender, EventArgs e)
        {
            int idClasse = int.Parse(textidclasse.Text);
            Classe classe = context.Classe.FirstOrDefault(et => et.id == idClasse);

            if (classe != null)
            {
                classe.libelle = comboNiveau.Text + comboSpecialite.Text;
               classe.niveau = comboNiveau.Text;
                classe.specialite = comboSpecialite.Text;

                context.SaveChanges();

                dataGridViewClasse.DataSource = context.Classe.ToList();

                MessageBox.Show("Modification réussie !");
            }
            else
            {
                MessageBox.Show("Classe non trouvé !");
            }
        }

        private void dataGridViewClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClasse.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string niveau = row.Cells["niveau"].Value.ToString();
                string specialite = row.Cells["specialite"].Value.ToString();
               

                  textidclasse.Text = id;
                  comboNiveau.Text = niveau;
                  comboSpecialite.Text = specialite;
               
            }
        }

        private void effacherclasse_Click(object sender, EventArgs e)
        {
            textidclasse.Text = "";
            comboNiveau.Text = "";
            comboSpecialite.Text = "";
        }

      

        private void supprimer_Click(object sender, EventArgs e)
        {
            int idEtudiant = int.Parse((textIdEtudiant.Text));
            Etudiant etudiant = context.Etudiant.FirstOrDefault(et => et.id == idEtudiant);
            context.Etudiant.Remove(etudiant);
            context.SaveChanges();
            rechargerDatagridviewEtudiant();
        }

        private void supprimerclasse_Click(object sender, EventArgs e)
        {
            int idClasse = Convert.ToInt32(textidclasse.Text);
            Classe classe = context.Classe.FirstOrDefault(et => et.id == idClasse);
            context.Classe.Remove(classe);
            context.SaveChanges();
            dataGridViewClasse.DataSource = context.Classe.ToList();
        }

        private void rechercheClasse_Click(object sender, EventArgs e)
        {
            string libelleClasse = textclasse.Text;
            Classe classe = context.Classe.FirstOrDefault(c => c.libelle == libelleClasse);

            if (classe != null)
            {
                   
                dataGridViewClasse.DataSource = new List<Classe> { classe };
            }
            else
            {
                MessageBox.Show("Classe non trouvée !");
            }
        }

        private void retourlisteclasse_Click(object sender, EventArgs e)
        {
            dataGridViewClasse.DataSource = context.Classe.ToList();
        }

        private void retourlisteetudiant_Click(object sender, EventArgs e)
        {
            rechargerDatagridviewEtudiant();
        }
    }
}
