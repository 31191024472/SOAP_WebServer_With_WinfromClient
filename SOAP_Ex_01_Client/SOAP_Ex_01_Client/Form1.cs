using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOAP_BaiTap_01_World_Client.WorldServiceReference;

namespace SOAP_BaiTap_01_World_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        WorldServiceSoapClient WorldSerVice = new WorldServiceSoapClient();
        private void bt_GetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                var countries = WorldSerVice.GetAllCountries(); // Lấy dữ liệu từ dịch vụ
                Responsive_Data.DataSource = countries;    // Gán dữ liệu vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách quốc gia: {ex.Message}");
            }
        }

        private void bt_GetCitiesByCountry_Click(object sender, EventArgs e)
        {
            try
            {
                string CountryCode = Txt_Country.Text.Trim();
                if (string.IsNullOrEmpty(CountryCode)) {
                    MessageBox.Show("Vui lòng nhập Mã Quốc Gia");
                    return;
                }
                var Citites = WorldSerVice.GetCitiesByCountry(CountryCode);
                if (Citites != null) { 
                    Responsive_Data.DataSource = Citites;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thành phố nào");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không tìm thấy thành phố : {ex.Message}");
            }
        }

        private void Bt_GetCitysByName_Click(object sender, EventArgs e)
        {
            try
            {
                string CityName = Txt_CityName.Text.Trim();
                if (string.IsNullOrEmpty(CityName))
                {
                    MessageBox.Show("Vui lòng nhập tên Thành Phố");
                    return ;
                }
                var CityNameData = WorldSerVice.GetCityByName(CityName);
                if (CityNameData != null) 
                {
                    Console.WriteLine(">>> Chekc Data:",CityName);
                    Responsive_Data.DataSource = new List<City> { CityNameData };
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Thành Phố nào");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không tìm thấy thành phố : {ex.Message}");
            }
        }

        private void Bt_GetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                string CountryCode = Txt_CountryCode.Text.Trim();
                if (string.IsNullOrEmpty(CountryCode)) 
                {
                    MessageBox.Show("Vui lòng nhập mã Quốc Gia");
                }
                var Conuntry = WorldSerVice.GetCountryByCode(CountryCode);
                if (Conuntry != null) 
                {
                    Responsive_Data.DataSource= new List<Country> { Conuntry};
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Quốc Gia Nào");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không tìm thấy Quốc Gia : {ex.Message}");

            }
        }

        private void Bt_GetAllContinents_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi phương thức lấy danh sách châu lục từ dịch vụ
                var continents = WorldSerVice.GetAllContinents();

                // Chuyển đổi danh sách string thành DataTable
                DataTable table = new DataTable();
                table.Columns.Add("Continent");
                foreach (var continent in continents)
                {
                    table.Rows.Add(continent);
                }

                // Gán DataTable vào DataSource của DataGridView
                Responsive_Data.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

    }
}
