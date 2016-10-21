using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;

namespace Ares.Infrastructure.Imaging
{
    public static class Image
    {
        #region 图像处理
        /// <summary>    
        /// 生成缩略图    
        /// </summary>    
        /// <param name="M_OriginalImagePath">源图路径（物理路径）</param>    
        /// <param name="M_ThumbnailPath">缩略图路径（物理路径）</param>    
        /// <param name="M_Width">缩略图宽度</param>    
        /// <param name="M_Height">缩略图高度</param>      
        public static void GenerateThumbnail(string M_OriginalImagePath, string M_ThumbnailPath, int M_Width, int M_Height)
        {

            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(M_OriginalImagePath);
            int towidth = 0;
            int toheight = 0;
            if (originalImage.Width >= M_Width && originalImage.Height <= M_Height)
            {
                towidth = M_Width;
                toheight = originalImage.Height;
            }
            if (originalImage.Width <= M_Width && originalImage.Height >= M_Height)
            {
                towidth = originalImage.Width;
                toheight = M_Height;
            }
            if (originalImage.Width >= M_Width && originalImage.Height >= M_Height)
            {
                towidth = M_Width;
                toheight = M_Height;
            }
            if (originalImage.Width <= M_Width && originalImage.Height <= M_Height)
            {
                towidth = originalImage.Width;
                toheight = originalImage.Height;
            }
            int x = 0;//左上角的x坐标    
            int y = 0;//左上角的y坐标    
            //新建一个bmp图片    
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板    
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法    
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度    
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充    
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分    
            g.DrawImage(originalImage, x, y, towidth, toheight);
            originalImage.Dispose();
            try
            {
                //以jpg格式保存缩略图    
                bitmap.Save(M_ThumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }

        #endregion 

        
        /// <summary>
        /// 将上传图片生成带水印和文字效果的缩略图
        /// </summary>
        /// <param name="postFile">上传的图片文件</param>
        /// <param name="saveImg">效果图的保存路径</param>
        /// <param name="Width">缩略图的宽度</param>
        /// <param name="Height">缩略图的高度</param>
        public static void MakeThumbnailImg(System.Web.HttpPostedFileBase postFile, string saveImg, System.Double Width, System.Double Height)
        {

            //原始图片名称
            string originalFilename = postFile.FileName;
            //生成的高质量图片名称
            string strGoodFile = saveImg;
            //从文件取得图片对象
            System.Drawing.Image image = System.Drawing.Image.FromStream(postFile.InputStream, true);
            //判断指定的图片大小
            System.Double NewWidth, NewHeight;
            NewWidth = Width;
            NewHeight = Height;
            //if (image.Width > image.Height)
            //{
            //    NewWidth = Width;
            //    NewHeight = image.Height * (NewWidth / image.Width);
            //}
            //else
            //{
            //    NewHeight = Height;
            //    NewWidth = (NewHeight / image.Height) * image.Width;
            //}
            //if (NewWidth > Width)
            //{
            //    NewWidth = Width;
            //}
            //if (NewHeight > Height)
            //{
            //    NewHeight = Height;
            //}
            //取得图片大小
            System.Drawing.Size size = new Size((int)NewWidth, (int)NewHeight);
            //新建一个bmp图片
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(size.Width, size.Height);
            //新建一个画板
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空一下画布-背景色设置为白色即可
            g.Clear(Color.White);
            //在指定位置画图
            g.DrawImage(image, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height),
                new System.Drawing.Rectangle(0, 0, image.Width, image.Height),
                System.Drawing.GraphicsUnit.Pixel);

            //Bitmap newImg = new Bitmap(bitmap.Width, bitmap.Height);
            //Graphics newGraphics = Graphics.FromImage(newImg);
            //newGraphics.DrawImage(bitmap, new System.Drawing.Rectangle(0, 0, newImg.Width, newImg.Height),
            //    new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height),
            //    System.Drawing.GraphicsUnit.Pixel);
            //newImg.Save(strGoodFile, System.Drawing.Imaging.ImageFormat.Jpeg);
            //bitmap.Dispose();
            //bitmap = newImg;
            //newGraphics.Dispose();
            //g.Dispose();
            
            /*
            //添加文字水印
            System.Drawing.Graphics G = System.Drawing.Graphics.FromImage(bitmap);
            System.Drawing.Font f = new Font("宋体", 10);
            System.Drawing.Brush b = new SolidBrush(Color.Black);
            //添加缩略图中的文字
            G.DrawString("CGJ", f, b, 10, 10);
            G.Dispose();

            //图片水印
            //获取水印文件
            System.Drawing.Image copyImage = System.Drawing.Image.FromFile(@"E:\My Excerise\C11\water.jpg");
            //新绘图
            Graphics a = Graphics.FromImage(bitmap);
            a.DrawImage(copyImage, new Rectangle(bitmap.Width - copyImage.Width, bitmap.Height - copyImage.Height,
                copyImage.Width, copyImage.Height), 0, 0, copyImage.Width, copyImage.Height, GraphicsUnit.Pixel);
            copyImage.Dispose();
            //释放资源
            a.Dispose();
            copyImage.Dispose();
            */

            //保存高清晰度的缩略图
           

            bitmap.Save(strGoodFile, System.Drawing.Imaging.ImageFormat.Jpeg);

            g.Dispose();
            image.Dispose();
            bitmap.Dispose();
        }
    }
}
