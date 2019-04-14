using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;


namespace FranciszekGrobelnyLab3Zad1
{
    public partial class FormMain : Form
    {
       
        SqlConnection connection = new SqlConnection(@"Data Source = YOU; database = Calendar; Trusted_Connection=Yes");
        
        public FormMain()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Przycisk wypisujący tabele wcześniej utworzoną.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Calendar", connection);
            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridViewCalendar.DataSource = table;
        }
        /// <summary>
        /// Przycisk wypisuje dokładniejsze dane o wydarzeniu(pokazuje godziny rozpoczęcia i zakończenia).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectDay_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Day WHERE Day ={textBoxSelectDay.Text}", connection);
            DataTable table = new DataTable();


            adapter.Fill(table);

            dataGridViewCalendar.DataSource = table;

        }
        /// <summary>
        /// Przycik dodający wydarzenie do tabeli Calendar i Day.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect =
                new SqlConnection(@"Data Source = YOU; database = Calendar; Trusted_Connection=Yes");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO Calendar(Day, Month, Name) VALUES (" + textBoxAddDay.Text + ",'" + textBoxAddMonth.Text+"','"+textBoxAddEvent.Text+"')";
            cmd.Connection = sqlConnect;

            sqlConnect.Open();
            cmd.ExecuteNonQuery();
            sqlConnect.Close();
            // dodajemy wydarzenie do tabeli Day wraz z godzinami(opcjonalnie).
            System.Data.SqlClient.SqlCommand comd = new System.Data.SqlClient.SqlCommand();
            comd.CommandType = System.Data.CommandType.Text;
            comd.CommandText = $"INSERT INTO Day(Day, Month, Name, StartTime, StopTime) VALUES (" + textBoxAddDay.Text + ",'" + textBoxAddMonth.Text + "','" + textBoxAddEvent.Text + "','" + textBoxStartTime.Text + "','" + textBoxStopTime.Text + "')";
            comd.Connection = sqlConnect;

            sqlConnect.Open();
            comd.ExecuteNonQuery();
            sqlConnect.Close();


        }
        /// <summary>
        /// Przycisk usuwający dane z tabel Calendar i Day.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect =
                new SqlConnection(@"Data Source = YOU; database = Calendar; Trusted_Connection=Yes");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"DELETE FROM Calendar WHERE Name = '" + textBoxAddEvent.Text + "'  ";
            
            cmd.Connection = sqlConnect;

            sqlConnect.Open();
            cmd.ExecuteNonQuery();
            sqlConnect.Close();

            System.Data.SqlClient.SqlCommand comd = new System.Data.SqlClient.SqlCommand();
            comd.CommandType = System.Data.CommandType.Text;
            comd.CommandText = $"DELETE FROM Day WHERE Name = '" + textBoxAddEvent.Text + "'  ";

            comd.Connection = sqlConnect;

            sqlConnect.Open();
            comd.ExecuteNonQuery();
            sqlConnect.Close();
            // Dodatkowo puszczany jest efekt dźwiękowy.
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\FRANEK\Desktop\KREDEK\Franciszek_Grobelny\lab3\FranciszekGrobelnyLab3\FranciszekGrobelnyLab3Zad1\applause.wav");
            splayer.Play();

            


        }
        /// <summary>
        /// Przycisk pozwalający natpisać dane o godziny(jeśli nie zrobiliśmy tego wcześniej lub chcemy je zmienić).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(@"Data Source = YOU; database = Calendar; Trusted_Connection=Yes");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE Day SET StartTime = '" + textBoxStartTime.Text + "' , StopTime = '" + textBoxStopTime.Text + "'  WHERE Name = '" + textBoxAddEvent.Text + "' ; ";

            cmd.Connection = sqlConnect;

            sqlConnect.Open();
            cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }
        /// <summary>
        /// Przycisk wyrzucający message Boxa, aby wszystkie opcje były jasne dla użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Opcje Terminarza:
1. Wyświetl/odśwież tabele wydarzeń.
2. Dodaj wydarzenie.
3. Usuń wydrzenie.
4. Dodaj godzieny.
5. Wyświetl dokładniejsze dane.
___________________________________

1. Naciśnij na przycisk (Wczytaj wydarzenie),aby pokazały się twoje aktualne wydarzenia.
Ten sam przycisk odswieża tabele po dodaniu wydarzenia.

2.Wpisz w tabele odpowiednie wartości, a nastęnie wciśnij przycisk (Dodaj Wydarzenie).Pamiętaj o odświerzeniu tabeli.

3.Możesz usunąc wydarzenie wpisując do rubryki (Nazwa wydarzenia) Wydazenie, które chcesz usunąć i naciskając przycisk (Usuń wydazenie).
Usunięcie wydarzenia równe jest jego wykonaniu. BRAWO!!!

4.Jeśli chcesz uzupełnić wydarzenie o godziny rozpoczęcia i zakończenia wpisz w odpowiednie rybryki wartości.Należy podać również nazwe wydarzenia i nacisąc przycisk (Dodaj godziny do wydarzenia).
Automatycznie są one równe 00:00.

5.Aby wyświetlić dokładne dane wyarzenia wystarczy w pole nad przyciskiem (Wyszukaj według dnia) podać dzień jaki nas interesuje i nacisąc na przycik.");
        }
    }
}
