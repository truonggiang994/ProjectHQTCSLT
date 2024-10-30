using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class UserControlDCCT : UserControl
    {
        public UserControlDCCT()
        {
            InitializeComponent();
            LoadLocations();
        }


        //Khu vực

        // Dictionary để chứa dữ liệu tỉnh thành và quận huyện
        private Dictionary<string, List<string>> locations = new Dictionary<string, List<string>>();

        // Hàm để đọc file JSON và lưu vào Dictionary
        private void LoadLocations()
        {
            // Kiểm tra nếu đã có dữ liệu trong locations
            if (locations.Any())
            {
                return;
            }

            // Lấy đường dẫn tới thư mục chứa file Address.json
            string resourcesFolder = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory); // D:\IT\ProjectHQTCSLT\Job\Job\bin\Debug\Resources

            string projectBasePath = resourcesFolder.Substring(0, resourcesFolder.IndexOf(@"\bin"));
            string fullPath = Path.Combine(projectBasePath, "Resources", "Address.json");

            // Đọc nội dung file JSON
            string jsonContent = File.ReadAllText(fullPath);

            // Deserialise JSON vào Dictionary
            locations = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonContent);

            // Gán danh sách tỉnh thành vào comboBoxTinhThanh
            comboBoxTinhThanh.DataSource = new BindingSource(locations, null); // Sử dụng BindingSource để gán

            // Đặt tên hiển thị cho comboBoxTinhThanh
            comboBoxTinhThanh.DisplayMember = "Key"; // Hiển thị tên tỉnh thành
        }

        // Sự kiện khi người dùng chọn tỉnh thành
        private void comboBoxTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTinhThanh.SelectedItem != null)
            {
                var selectedProvince = (KeyValuePair<string, List<string>>)comboBoxTinhThanh.SelectedItem;
                comboBoxQuanHuyen.DataSource = selectedProvince.Value; // Gán danh sách quận huyện tương ứng
            }
        }

        public event EventHandler DeleteRequested;

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện DeleteRequested để thông báo cho thằng cha
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
