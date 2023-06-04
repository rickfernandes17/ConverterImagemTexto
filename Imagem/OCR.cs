using IronOcr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagem
{
    public static class OCR
    {
        public static string Converter(string path) {
            try {
                IronTesseract orc = new IronTesseract();
                var result = orc.Read(path);
                return result.Text; 
            }
            catch (Exception ex) {
                return "Error# " + ex.Message;
            }
        }
    }
}
