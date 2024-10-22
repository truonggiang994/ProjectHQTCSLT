using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class FCamNang : Form
    {
        private CamNang camNang;

        public FCamNang(CamNang camNang)
        {
            this.camNang = camNang;
            InitializeComponent();
            TaiDuLieu();

        }
                

        private void TaiDuLieu()
        {
           
                MY_DB db = new MY_DB();
                db.OpenConnection(); // Kiểm tra kết nối
           
        }



    }
}
