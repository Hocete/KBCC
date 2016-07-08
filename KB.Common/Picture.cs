﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace KB.Common
{
    /// <summary>
    /// 图片相关
    /// <remarks>
    /// 创建：2014.02.11
    /// </remarks>
    /// </summary>
    public class Picture
    {
        /// <summary>
        /// 创建缩略图
        /// </summary>
        /// <param name="originalPicture">原图地址</param>
        /// <param name="thumbnail">缩略图地址</param>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        /// <returns>是否成功</returns>
        public static bool CreateThumbnail(string originalPicture, string thumbnail, int width, int height)
        {
            //原图
            Image _original = Image.FromFile(originalPicture);
            // 原图使用区域
            RectangleF _originalArea = new RectangleF();
            //宽高比
            float _ratio = (float)width / height;
            if (_ratio > ((float)_original.Width / _original.Height))
            {
                _originalArea.X = 0;
                _originalArea.Width = _original.Width;
                _originalArea.Height = _originalArea.Width / _ratio;
                _originalArea.Y = (_original.Height - _originalArea.Height) / 2;
            }
            else
            {
                _originalArea.Y = 0;
                _originalArea.Height = _original.Height;
                _originalArea.Width = _originalArea.Height * _ratio;
                _originalArea.X = (_original.Width - _originalArea.Width) / 2;
            }
            Bitmap _bitmap = new Bitmap(width, height);
            Graphics _graphics = Graphics.FromImage(_bitmap);
            //设置图片质量
            _graphics.InterpolationMode = InterpolationMode.High;
            _graphics.SmoothingMode = SmoothingMode.HighQuality;
            //绘制图片
            _graphics.Clear(Color.Transparent);
            _graphics.DrawImage(_original, new RectangleF(0, 0, _bitmap.Width, _bitmap.Height), _originalArea, GraphicsUnit.Pixel);
            //保存
            _bitmap.Save(thumbnail);
            _graphics.Dispose();
            _original.Dispose();
            _bitmap.Dispose();
            return true;
        }
    }
}
