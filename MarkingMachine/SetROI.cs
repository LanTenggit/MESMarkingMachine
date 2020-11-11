using HalconHelper;
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

namespace MarkingMachine
{
    public partial class SetROI : Form
    {
        public SetROI()
        {
            InitializeComponent();
        }
        Bitmap DstBmp;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files(*.*) |*.*|Bitmap files (*.Bitmap)|*.Bmp|Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap Bmp = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                DstBmp = (Bitmap)Bmp.Clone();
                Bmp.Dispose();
                HalconHelper.HalconCommonly halconCommonly = new HalconCommonly();
                halconCommonly.Adaptation_Window(new HalconHelper.HalconCommonly().FromBitmap32(DstBmp), hWindowControl1); //显示图像完全显示
                HalconHelper.TemplateMatching templateMatching = new TemplateMatching();
                templateMatching.Buildtemplate(hWindowControl1.HalconWindow, //视图
                    new HalconHelper.HalconCommonly().FromBitmap32(DstBmp)//图像 
                    );
            }
        }
        string ModelPath = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            ModelPath = Path.GetFullPath("ModelImg");
            ModelPath += "/Model.dfm";
            //工程需要在x64位
            HalconHelper.TemplateMatching templateMatching = new TemplateMatching();
            var result = templateMatching.Findtemplates(hWindowControl1.HalconWindow,//视图
           new HalconHelper.HalconCommonly().FromBitmap32(DstBmp), ModelPath); //模板路径 //图像
            System.Diagnostics.Debug.Print(result.Count.ToString()); //返回list集合,value为相似度,剩下的自行判断,一般0.9以上都可以被认识是OK
        }
    }
}
