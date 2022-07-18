using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMWCell
{
    static class Warehouse
    {
        static string readSerial;
        
        static bool warehouseExists = false;
        static int rows = 6;
        static int lines = 30;
        static string[,,] palletSpaces;
        static Warehouse() 
        {
            palletSpaces = new string[rows,lines,2];
            initializePalletSpaces();
        }
        private static void initializePalletSpaces() 
        {
            
            if (warehouseExists)
            {

            }
            else 
            {
                for (int i = 0; i < rows; i++) 
                {
                    for (int j = 0; j < lines; j++) 
                    {
                        palletSpaces[i,j,0] = "";
                        palletSpaces[i,j,1] = "";                    
                    }
                }
                warehouseExists = true;
            }
        }

        public static string findPalletSpace() 
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < lines; j++)
                {
                    if (palletSpaces[i,j,0] == "")
                    {
                        return (i+1).ToString() + "." + (j+1).ToString();
                    }
                }
            }
            return "MAGAZYN PEŁEN";
        }
        public static string savePallet(string date, string pID) 
        {
            if (findPalletSpace() == "MAGAZYN PEŁEN")
            {
                return "MAGAZYN PEŁEN";
            }
            else
            {
                string[] position = findPalletSpace().Split(".");
                int i = Convert.ToInt32(position[0]) - 1;
                int j = Convert.ToInt32(position[1]) - 1;
                palletSpaces[i, j, 0] = date;
                palletSpaces[i, j, 1] = pID;
                return "ZAPISANO: " + position[0].ToString() + "." + position[1].ToString();
            }
        }

        public static string findPosition(string palletID) 
        {
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    if (palletSpaces[i, j, 1] == palletID)
                    {
                        return (i + 1).ToString() + "." + (j + 1).ToString();
                    }
                }
            }
            return "BRAK PALETY";
        }
        public static string prepareList(string givenList) 
        {
            string pickList = "";
            string[] givenArray = givenList.Split("\n");
            List<string> palletList = new List<string>();

            foreach (string l in givenArray) 
            {
                palletList.Add(l.TrimEnd(new char[] { '\r', '\n' }));
            }
            List<string> positionList = new List<string>();
            
            
            foreach (string e in palletList) 
            {
                positionList.Add(findPosition(e));
            }

            for (int i = 0; i < palletList.Count(); i++) 
            {
                pickList = pickList + palletList[i] + " -> " + positionList[i] + "\n";
            }

            return pickList;
        }
        private static string serializeWarehouse() 
        {
            string serial = "";
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < lines; j++) 
                {
                    serial = serial + palletSpaces[i,j,0] + ";" + palletSpaces[i,j,1] + "\n";
                }
            }
            return serial;
        }

        private static void deserializeWarehouse() 
        {
            readSerial = File.ReadAllText("warehousestate.txt");
            string[] rowSplit = readSerial.Split("\n");
            foreach (string e in rowSplit) 
            {
                string[] lineSplit = e.Split(";");
            } 
        }
        public static async void saveWarehouseState() 
        {
            await File.WriteAllTextAsync("warehousestate.txt", serializeWarehouse());
        }
    }
}
