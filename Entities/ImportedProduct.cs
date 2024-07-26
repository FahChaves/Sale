using System.Globalization;

namespace sale.Entities{
    class ImportedProduct: Product{
        public double CostomsFre{ get; set; }

        public ImportedProduct(){

        }
        public ImportedProduct(string name, double price, double costomsFre)
        : base (name, price){
            CostomsFre = costomsFre;
        }

         public double TotalPrice(){
            return Price =+ CostomsFre;
        }
        public override string PriceTag()
        {
            return Name 
            + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) 
            + "(Customs fee: $ " 
            + CostomsFre.ToString("F2", CultureInfo.InvariantCulture)
            + ")";        }

       
    }
}