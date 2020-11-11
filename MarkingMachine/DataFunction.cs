using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkingMachine
{
    public class DataFunction
    {
        /// <summary>
        /// 写入TXT文件
        /// </summary>
        /// <param name="txtPath"></param>
        /// <param name="str"></param>
        public static void txtWrite(string str)
        {
            string padjfdtxt = Path.GetFullPath("Error.txt");
            StreamWriter sw = new StreamWriter(padjfdtxt, true);
            //System.Text.Encoding.GetEncoding("GB2312") = 
            str += System.DateTime.Now;
            sw.WriteLine(str);
            sw.Close();

            //Dim strArr As String() = {str}
            //File.WriteAllLines(txtPath, strArr, System.Text.Encoding.GetEncoding("GB2312")) '写入到新文件中


        }

        /// <summary>
        /// 根据图片路径返回图片的字节流byte[]
        /// </summary>
        /// <param name="imagePath">图片路径</param>
        /// <returns>返回的字节流</returns>
        public static byte[] GetImageByte(string imagePath)
        {
            FileStream files = new FileStream(imagePath, FileMode.Open);
            byte[] imgByte = new byte[files.Length];
            files.Read(imgByte, 0, imgByte.Length);
            files.Close();
            return imgByte;
        }

        /// <summary>
        /// 得到base64文件
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static string GetBase64StringByImage(Image img)
        {
            string base64buffer = string.Empty;

            try
            {
                if (img != null)
                {
                    byte[] bytes = PhotoImageInsert(img);
                    base64buffer = Convert.ToBase64String(bytes);
                }
            }
            catch (Exception ex)
            { }
            return base64buffer;
        }


        //将Image转换成流数据，并保存为byte[] 
        public static byte[] PhotoImageInsert(Image imgPhoto)
        {
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length); mstream.Close();
            return byData;

        }

        /// <summary>
        /// 获取某目录下的所有文件(包括子目录下文件)的数量
        /// </summary>
        /// <param name="srcPath"></param>
        /// <returns></returns>
        public static int GetFileNum(string srcPath)
        {
            int fileNum = 0;
            try
            {

                string[] fileList = System.IO.Directory.GetFileSystemEntries(srcPath);
                foreach (string file in fileList)
                {
                    if (System.IO.Directory.Exists(file))
                        GetFileNum(file);
                    else
                        fileNum++;
                }

            }
            catch (Exception)
            {

            }
            return fileNum;
        }



        /// <summary>
        /// 删除文件夹里的所有文件
        /// </summary>
        /// <param name="srcPath"></param>
        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 切割图片
        /// </summary>
        /// <param name="sourceBitmap">图片对象</param>
        /// <param name="width">切割的宽度</param>
        /// <param name="height">切割的高度</param>
        /// <param name="offsetX">开始的x</param>
        /// <param name="offsetY">开始的y</param>
        /// <returns></returns>
        public static Bitmap GetPartOfImageRec(Bitmap sourceBitmap, int width, int height, int offsetX, int offsetY)
        {
            Bitmap resultBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resultBitmap))
            {
                Rectangle resultRectangle = new Rectangle(0, 0, width, height);
                Rectangle sourceRectangle = new Rectangle(0 + offsetX, 0 + offsetY, width, height);
                g.DrawImage(sourceBitmap, resultRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }
            return resultBitmap;
        }




    }
}
