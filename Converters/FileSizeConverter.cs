using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace FolderOrganiser.Converters
{
    internal class FileSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int extension)
            {
                if (extension < 1024)
                {
                    return $"{extension} B";
                }
                else if (extension < 1024 * 1024)
                {
                    return $"{extension / 1024.0:F2} KB";
                }
                else if (extension < 1024 * 1024 * 1024)
                {
                    return $"{extension / (1024.0 * 1024):F2} MB";
                }
                else
                {
                    return $"{extension / (1024.0 * 1024 * 1024):F2} GB";
                }
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
