using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Drawing;
using OfficeOpenXml.Style;
using System.IO;

namespace BMWCell
{
    class documentPrinter
    {

        ExcelPackage package;
        
        Pallet[,] palletList = Warehouse.palletSpaces;
        public documentPrinter()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            package = new ExcelPackage();
        }
        public void printWholeStock() 
        {
            var ws = package.Workbook.Worksheets.Add("PalletList");
            ws.Cells[1, 1].Value ="Lokalizacja" ;
            ws.Cells[1, 2].Value ="PalletID";
            ws.Cells[1, 3].Value ="Data przyjęcia" ;
            int k = 2;
            
            for (int i = 0; i < palletList.GetLength(0); i++) 
            {
                for (int j = 0; j < palletList.GetLength(1); j++) 
                {
                    ws.Cells[k, 1].Value = (i+1).ToString() + "." + (j+1).ToString();
                    if (palletList[i, j] != null)
                    {
                        ws.Cells[k, 2].Value = palletList[i, j].getPalletID();
                        ws.Cells[k, 3].Value = palletList[i, j].getPalletDate().Date;
                        ws.Cells[k, 3].Style.Numberformat.Format = "dd-mm-yyyy";
                    }
                    else 
                    {
                        ws.Cells[k, 2].Value = "-";
                        ws.Cells[k, 3].Value = "-";
                    }
                    k++;
                }
            }
            ws.Column(1).AutoFit();
            ws.Column(2).AutoFit();
            ws.Column(3).AutoFit();
            FileInfo fi = new FileInfo("TotalStock.xlsx");
            package.SaveAs(fi);
        }
        public void printPickList(List<Pallet> palletList) 
        {
            var ws = package.Workbook.Worksheets.Add("PickList");
            ws.Cells[1, 1].Value = "Lokalizacja";
            ws.Cells[1, 2].Value = "PalletID";
            ws.Cells[1, 3].Value = "Data przyjęcia";
            int[] temp;
            int k = 2;

            foreach (Pallet p in palletList) 
            {
                temp = Warehouse.findPallet(p);
                if (Warehouse.findAndReturnPalletObjectByID(p.getPalletID()) != null)
                {
                    ws.Cells[k, 1].Value = temp[0].ToString() + "." + temp[1].ToString();
                    ws.Cells[k, 2].Value = p.getPalletID();
                    ws.Cells[k, 3].Value = p.getPalletDate();
                }
                else 
                {
                    ws.Cells[k, 2].Value = p.getPalletID();
                    ws.Cells[k, 3].Value = "BRAK PALETY O PODANYM ID NA MAGAZYNIE";
                }
                k++;
            }
            FileInfo fi = new FileInfo("PickingList_"+ DateTime.Now.Date.ToString().Replace(":","_") + ".xlsx");
            package.SaveAs(fi);
        }

    }
   
}
