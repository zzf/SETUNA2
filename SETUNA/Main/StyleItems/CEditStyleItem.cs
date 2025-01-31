﻿using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace SETUNA.Main.StyleItems
{
    using SETUNA.Properties;

    // Token: 0x02000013 RID: 19
    public class CEditStyleItem : CStyleItem
    {
        // Token: 0x060000DC RID: 220 RVA: 0x000068BC File Offset: 0x00004ABC
        public CEditStyleItem()
        {
            //isDoOpenEditor = false;
        }

        // Token: 0x060000DD RID: 221 RVA: 0x000068CC File Offset: 0x00004ACC
        public override void Apply(ref ScrapBase scrap, Point clickpoint)
        {
            /*
            if (true == isDoOpenEditor)
            {
                TimeSpan ts = DateTime.Now - lastEditrTime;
                if(ts.TotalSeconds > 10)
                {
                    isDoOpenEditor = false;
                }
            }
            */

            Debug.WriteLine("Save ------------");
            //var text = Application.StartupPath;
            //text = System.IO.Path.GetFullPath(System.IO.Path.Combine(text, "editr_files"));
            var text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Application.ProductName, "capturedFiles");
            if (!System.IO.Directory.Exists(text))
            {
                System.IO.Directory.CreateDirectory(text);
            }
            else
            {
                string[] files = System.IO.Directory.GetFiles(text);
                foreach (var file in files)
                {
                    System.IO.File.Delete(file);
                }
            }

            string tmp_str ="screenshot_" + DateTime.Now.ToLongTimeString().Replace(":", "_").Replace(" ", "_");
            string image_path = System.IO.Path.Combine(text, tmp_str + ".png");
            Debug.WriteLine(String.Format("image_path = {0}", image_path));
            //MessageBox.Show("CEditStyleItem 1 image_path = " + image_path, "SETUNA3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            var image = (Image)scrap.Image.Clone();
            image.Save(image_path);

            var pinf = new ProcessStartInfo(@"C:\WINDOWS\system32\mspaint.exe", image_path);
            Process.Start(pinf);
            //下面的代码会执行两次
            //var pro = Process.Start(pinf);
            //pro.Start();
            //打开之后关闭原截图
            scrap.Close();
        }

        public override string GetName()
        {
            return "Edit";
        }

        // Token: 0x060000DF RID: 223 RVA: 0x00006967 File Offset: 0x00004B67
        public override string GetDisplayName()
        {
            return "使用画图工具打开";
        }

        // Token: 0x060000E0 RID: 224 RVA: 0x0000696E File Offset: 0x00004B6E
        public override string GetDescription()
        {
            return "使用画图工具打开，以编辑截图";
        }

        // Token: 0x060000E1 RID: 225 RVA: 0x00006975 File Offset: 0x00004B75
        protected override ToolBoxForm GetToolBoxForm()
        {
            return new EditStyleItemPanel(this);
        }

        // Token: 0x060000E2 RID: 226 RVA: 0x00006980 File Offset: 0x00004B80
        protected override void SetTunedStyleItem(CStyleItem newOwn)
        {

        }

        // Token: 0x060000E3 RID: 227 RVA: 0x000069A0 File Offset: 0x00004BA0
        public override Bitmap GetIcon()
        {
            return Resources.Icon_Copy;
        }

        //private static bool isDoOpenEditor = false;
        //private static DateTime lastEditrTime;
    }
}
