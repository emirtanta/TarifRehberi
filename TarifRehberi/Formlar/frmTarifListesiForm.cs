using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarifRehberi.Formlar
{
    public partial class frmTarifListesiForm : Form
    {
        // Person listesi
        List<Person> persons = new List<Person>();

        public frmTarifListesiForm()
        {
            InitializeComponent();


            // DataGridView'deki tüm hücreler düzenlenebilir olur
            dataGridView1.ReadOnly = false;

            // DataGridView'a buton ekleme
            //DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            //btnUpdate.HeaderText = "Güncelle";
            //btnUpdate.Text = "Güncelle";
            //btnUpdate.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(btnUpdate);

            //DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            //btnDelete.HeaderText = "Sil";
            //btnDelete.Text = "Sil";
            //btnDelete.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(btnDelete);

            // İlk veriyi ekleyelim
            persons.Add(new Person { Id = 1, Name = "Ali", Surname = "Yılmaz", Age = 25 });
            persons.Add(new Person { Id = 2, Name = "Ayşe", Surname = "Kara", Age = 30 });

            // Listeyi yükle
            LoadData();

            
        }

        // DataGridView'a verileri yükleme
        private void LoadData()
        {
            dataGridView1.DataSource = null; // Önceki verileri temizle
            dataGridView1.DataSource = persons; // Listeyi DataGridView'e bağla
        }
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçerli bir satır seçilmiş mi kontrol et
            if (e.RowIndex >= 0)
            {
                // Seçili satırdan ID değerini al
                if (dataGridView1.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                    // Person nesnesini bul
                    Person person = persons.FirstOrDefault(p => p.Id == id);

                    if (person != null)
                    {
                        // Güncelleme formunu oluştur
                        using (Form updateForm = new Form())
                        {
                            updateForm.Text = "Güncelle"; // formun adı
                            updateForm.Size = new Size(500, 500); // formun büyüklüğü
                            updateForm.StartPosition = FormStartPosition.CenterScreen; // formun açılacak yeri

                            // İsim için TextBox
                            Label lblName = new Label() 
                            { 
                                Text = "İsim:",
                                Font = new Font("Microsoft Sans Serif",9, FontStyle.Bold),
                                //Location = new Point(10, 20) 
                                Location = new Point(70, 20) 
                            };

                            TextBox txtName = new TextBox() 
                            {
                                //Location = new Point(120, 20),//formun sağ tarafına kaydırır 
                                Location = new Point(180, 20),
                                AutoSize=true,
                                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                                Width = 150, 
                                Text = person.Name 
                            };

                            // Soyisim için TextBox
                            Label lblSurname = new Label() 
                            { 
                                Text = "Soyisim:",
                                Font=new Font("Microsoft Sans Serif", 9,FontStyle.Bold),
                                //Location = new Point(10, 60) //formun sağ tarafına kaydırır 
                                Location = new Point(70, 60) 
                            };

                            TextBox txtSurname = new TextBox() 
                            { 
                                //Location = new Point(120, 60),
                                Location = new Point(180, 60),
                                AutoSize = true,
                                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                                Width = 150, 
                                Text = person.Surname 
                            };

                            // Kaydet butonu
                            Button btnSave = new Button() 
                            { 
                                Text = "Güncelle", 
                                //Location = new Point(120, 100),
                                Location = new Point(180, 100),
                                FlatStyle = FlatStyle.Flat,
                                BackColor = Color.Blue,
                                ForeColor = Color.White
                            };
                            btnSave.Click += (s, args) =>
                            {
                                // Güncellenmiş değerleri Person nesnesine atama
                                person.Name = txtName.Text;
                                person.Surname = txtSurname.Text;

                                LoadData(); // Verileri yeniden yükle
                                updateForm.DialogResult = DialogResult.OK;
                                updateForm.Close();
                            };

                            // Sil butonu
                            Button btnDelete = new Button() 
                            { 
                                Text = "Sil", 
                                //Location = new Point(200, 100),
                                Location = new Point(255, 100),
                                FlatStyle = FlatStyle.Flat,
                                BackColor = Color.Red,
                                ForeColor = Color.White
                            };
                            btnDelete.Click += (s, args) =>
                            {
                                // Silme onayı
                                DialogResult dialogResult = MessageBox.Show("Bu kişiyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    // Person listesinden sil
                                    persons.Remove(person);

                                    LoadData(); // Verileri yeniden yükle
                                    MessageBox.Show("Kişi başarıyla silindi.");
                                    updateForm.DialogResult = DialogResult.OK;
                                    updateForm.Close();
                                }
                            };

                            // Form kontrol elemanlarını ekle
                            updateForm.Controls.Add(lblName);
                            updateForm.Controls.Add(txtName);
                            updateForm.Controls.Add(lblSurname);
                            updateForm.Controls.Add(txtSurname);
                            updateForm.Controls.Add(btnSave);
                            updateForm.Controls.Add(btnDelete);

                            // Formu aç
                            updateForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kişi bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Seçili satırda geçerli bir ID bulunamadı.");
                }
            }


        }
    }

    // Person class'ı
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
