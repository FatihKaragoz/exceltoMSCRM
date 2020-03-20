using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToMSCRMImport
{
    public partial class ImportExcelForm : Form
    {
        public ImportExcelForm()
        {
            InitializeComponent();
        }

        private void ImportExcelForm_Load(object sender, EventArgs e)
        {

        }

        //Form üzerinde FileUploader ile masaüstündeki dosya alıancaktır.
        //Alınan dosyadaki alanlar okunacak.
        //Okunan alanlar ExcelObject objesine map edilecektir
        //Map edilen obje, MapHelper içerisindeki ObjectConvertoEntity metot ile Entity'e çevirilektir.
        //MSCRMHelper içerisindeki CreateEntityRecord metodu ile MS CRM sistemine alınacaktır.
    }
}
