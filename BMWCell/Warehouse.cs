using System;
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
        static string readSerial;
        
        static int rows = 6;
        static int lines = 30;
        static Pallet[,] palletSpaces { get; set; }
        public static string comm { get; set; }
        static Warehouse() 
        {
            palletSpaces = new Pallet[rows,lines];
        }

        public static void savePallet(Pallet pallet, int row, int line) {
            if (palletSpaces[row, line] == null)
            {
                palletSpaces[row, line] = pallet;
                comm += pallet + "DODANO PALETĘ";
            }
            else {
                comm += "MIEJSCE ZAJĘTE!" + palletSpaces[row, line];
            }
            saveWarehouseState();
        }

        public static void removePallet(int row, int line) {
            palletSpaces[row, line] = null;
        }


        public static int[] findPallet(Pallet pallet) 
        {
            int[] position = {0, 0};
            for (int i = 0; i <= rows; i++) 
            {
                for (int j = 0; j <= lines; j++) 
                {
                    if (palletSpaces[i, j].palletID == pallet.palletID) 
                    {
                        position[0] = i+1;
                        position[1] = j+1;
                        return position;
                    }
                }
            }
            return position;
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
