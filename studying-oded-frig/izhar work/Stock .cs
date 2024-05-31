using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace studying_oded_frig.izhar_work
{
    internal class Stock
    {
        public double ClosePrice = 189.98F;
        public double OpenPrice = 188.82F;
        public double HighPrice = 190.58F;
        public double LowPrice = 188.0404F;
        public double CurrentPrice;
        public string Sign = "AAPL";
        public string OfficialName = "Apple Inc";
        public double ChangePercent = 0.01;
        public bool StockStatus;

        public Stock(double CurrentHour, double currentPrice)
        {
            if ((CurrentHour > 7) && (CurrentHour < 22))
                this.StockStatus = true;
            else
                this.StockStatus = false;
            this.CurrentPrice = currentPrice;
         }

    

        public void StartDay(double Price)   //start day - setting the current price and the starting price and day is active
        {
            this.OpenPrice = this.CurrentPrice;
            this.CurrentPrice = Price;
            this.StockStatus = true;
        }

        public void FinishtDay(double Price) //finish day - setting the current price and the closing price
        {
            this.ClosePrice = Price;
            this.StockStatus = false;
        }

        public void SetPrice(double Price)        //set price - setting the price

        {
            this.CurrentPrice = Price;
        }





    }
}
