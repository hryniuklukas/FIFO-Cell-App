﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BMWCell
{
    static class Warehouse
    { 
        static int rows = 6;
        static int lines = 30;
        public static Pallet[,] palletSpaces { get; set; }
        public static string comm { get; set; }
        static Warehouse() 
        {
            palletSpaces = new Pallet[rows,lines];
        }

        public static void savePallet(Pallet pallet, int row, int line) {
            if (palletSpaces[row-1, line-1] == null)
            {
                palletSpaces[row-1, line-1] = pallet;
                comm += pallet.getPalletID() + "DODANO PALETĘ";
            }
            else {
                comm += "MIEJSCE ZAJĘTE!" + palletSpaces[row, line];
            }
            saveWarehouseState();
        }

        public static void removePallet(int row, int line) {
            palletSpaces[row-1, line-1] = null;
        }


        public static int[] findPallet(Pallet pallet) 
        {
            int[] position = {0, 0};
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < lines; j++) 
                {
                    if (palletSpaces[i, j] != null)
                    {
                        if (palletSpaces[i, j].palletID == pallet.palletID)
                        {
                            position[0] = i + 1;
                            position[1] = j + 1;
                            return position;
                        }
                    }
                }
            }
            return position;
        }
        public static Pallet findAndReturnPalletObjectByID(string palletID) 
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    if (palletSpaces[i, j] != null)
                    {
                        if (palletSpaces[i, j].palletID == palletID)
                        {
                            return palletSpaces[i, j];
                        }
                    }
                }
            }
            return null;

        }
        private static string jsonSerializeWarehouse() 
        {
            return JsonConvert.SerializeObject(palletSpaces);
        }

        public static void jsonDeserializeWarehouse() 
        {
            string fileName = "warehouseState.json";
            if (File.Exists(fileName))
            {
                palletSpaces = JsonConvert.DeserializeObject<Pallet[,]>(File.ReadAllText(fileName));
            }
        }
        public static async void saveWarehouseState() 
        {
            string fileName = "warehouseState.json";
            await File.WriteAllTextAsync(fileName, jsonSerializeWarehouse());
        }
    }
}
