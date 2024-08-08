namespace RentalCar.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Place { get; set; }
        public decimal KmInitial { get; set; }
        public decimal KmFinal { get; set; }
        public bool IsRended {  get; set; }   
    }
}
