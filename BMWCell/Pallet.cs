using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BMWCell
{
    class Pallet
    {
        public String palletID { get; set; }
        public DateTime palletDate { get; set; }

        [JsonConstructor]
        public Pallet(String palletID, DateTime palletDate) 
        {
            this.palletID = palletID;
            this.palletDate = palletDate;
        }
        public Pallet(String palletID) 
        {
            this.palletID = palletID;
        }
        public String getPalletID() {
            return this.palletID;
        }
        public DateTime getPalletDate() {
            return this.palletDate;
        }
        public override String ToString() {
            return palletID + " ; " + palletDate.ToString();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Pallet p = (Pallet)obj;
                return (this.palletID == p.palletID);
            }
        }
    }
}
